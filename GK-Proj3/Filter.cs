using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_Proj3
{
    public abstract class Filter
    {
        protected readonly byte Shift;
        protected readonly float[,] M = new float[3, 3];
        protected float? userDivider;
        protected float Divider 
        { 
            get
            {
                if (userDivider is float divider)
                {
                    return (divider != 0) ? divider : 1;
                }
                float sum = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        sum += M[i, j];
                    }
                }
                return (sum != 0) ? sum : 1;
            } 
        }
        protected Filter(byte shift, float? divider)
        {
            Shift = shift;
            userDivider = divider;
        }
        public void FilterImage(Color[,]? image)
        { 
            if (image is null)
            {
                return;
            }
            Color[,] filteredImage = new Color[image.GetLength(0), image.GetLength(1)];
            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    float addR = 0, addG = 0, addB = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (x + i - 1 < image.GetLength(0) && x + i - 1 >= 0 && y + j - 1 < image.GetLength(1) && y + j - 1 >= 0)
                            {
                                addR += M[i, j] * image[x + i - 1, y + j - 1].R;
                                addG += M[i, j] * image[x + i - 1, y + j - 1].G;
                                addB += M[i, j] * image[x + i - 1, y + j - 1].B;
                            }
                        }
                    }
                    filteredImage[x, y] = Color.FromArgb(Math.Clamp(Shift + (int)(addR / Divider), 0, 255),
                                                 Math.Clamp(Shift + (int)(addG / Divider), 0, 255),
                                                 Math.Clamp(Shift + (int)(addB / Divider), 0, 255));
                }
            }
            for (int x = 0; x < image.GetLength(0); x++)
            {
                for (int y = 0; y < image.GetLength(1); y++)
                {
                    image[x, y] = Color.FromArgb(filteredImage[x, y].R, filteredImage[x, y].G, filteredImage[x, y].B);
                }
            }
        }
    }
}
