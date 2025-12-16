using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

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
        public unsafe void FilterImage(Color[,]? oryginalImage, Bitmap? bitmap, int[] redCounts, int[] greenCounts, int[] blueCounts)
        { 
            if (oryginalImage is null || bitmap is null)
            {
                return;
            }

            BitmapData bd = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte* scan0 = (byte*)bd.Scan0;
            int stride = bd.Stride;

            for (int y = 0; y < oryginalImage.GetLength(1); y++)
            {
                byte* currRow = scan0 + (y * stride);
                for (int x = 0; x < oryginalImage.GetLength(0); x++)
                {
                    int offset = x * 4;

                    blueCounts[currRow[offset]]--;
                    greenCounts[currRow[offset + 1]]--;
                    redCounts[currRow[offset + 2]]--;

                    float addR = 0, addG = 0, addB = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (x + i - 1 < oryginalImage.GetLength(0) && x + i - 1 >= 0 && y + j - 1 < oryginalImage.GetLength(1) && y + j - 1 >= 0)
                            {
                                addR += M[i, j] * oryginalImage[x + i - 1, y + j - 1].R;
                                addG += M[i, j] * oryginalImage[x + i - 1, y + j - 1].G;
                                addB += M[i, j] * oryginalImage[x + i - 1, y + j - 1].B;
                            }
                        }
                    }

                    currRow[offset] = (byte)Math.Clamp(Shift + (int)(addB / Divider), 0, 255);
                    currRow[offset + 1] = (byte)Math.Clamp(Shift + (int)(addG / Divider), 0, 255);
                    currRow[offset + 2] = (byte)Math.Clamp(Shift + (int)(addR / Divider), 0, 255);
                    currRow[offset + 3] = 255;

                    blueCounts[currRow[offset]]++;
                    greenCounts[currRow[offset + 1]]++;
                    redCounts[currRow[offset + 2]]++;
                }
            }
            bitmap.UnlockBits(bd);
        }

        public unsafe void FilterImageWithBrush(Color[,]? oryginalImage, Bitmap? bitmap, Point brushPoint, int brushRadius, int[] redCounts, int[] greenCounts, int[] blueCounts)
        {
            if (oryginalImage is null || bitmap is null)
            {
                return;
            }
            int startY = Math.Max(0, brushPoint.Y - brushRadius);
            int endY= Math.Min(brushPoint.Y + brushRadius, oryginalImage.GetLength(1) - 1);

            BitmapData bd = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            byte* scan0 = (byte*)bd.Scan0;
            int stride = bd.Stride;

            for (int y = startY; y <= endY; y++)
            {
                byte* currRow = scan0 + (y * stride);
                int dy = y - brushPoint.Y;
                for (int x = Math.Max(0, brushPoint.X - brushRadius); x <= Math.Min(brushPoint.X + brushRadius, oryginalImage.GetLength(0) - 1); x++)
                {
                    int dx = x - brushPoint.X;
                    if (dx * dx + dy * dy <= brushRadius * brushRadius)
                    {
                        int offset = x * 4;

                        blueCounts[currRow[offset]]--;
                        greenCounts[currRow[offset + 1]]--;
                        redCounts[currRow[offset + 2]]--;

                        float addR = 0, addG = 0, addB = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (x + i - 1 < oryginalImage.GetLength(0) && x + i - 1 >= 0 && y + j - 1 < oryginalImage.GetLength(1) && y + j - 1 >= 0)
                                {
                                    addR += M[i, j] * oryginalImage[x + i - 1, y + j - 1].R;
                                    addG += M[i, j] * oryginalImage[x + i - 1, y + j - 1].G;
                                    addB += M[i, j] * oryginalImage[x + i - 1, y + j - 1].B;
                                }
                            }
                        }
                        currRow[offset] = (byte)Math.Clamp(Shift + (int)(addB / Divider), 0, 255);
                        currRow[offset + 1] = (byte)Math.Clamp(Shift + (int)(addG / Divider), 0, 255);
                        currRow[offset + 2] = (byte)Math.Clamp(Shift + (int)(addR / Divider), 0, 255);
                        currRow[offset + 3] = 255;

                        blueCounts[currRow[offset]]++;
                        greenCounts[currRow[offset + 1]]++;
                        redCounts[currRow[offset + 2]]++;
                    }
                }
            }

            bitmap.UnlockBits(bd);
        }
    }
}
