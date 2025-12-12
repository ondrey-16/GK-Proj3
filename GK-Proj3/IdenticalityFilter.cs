using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_Proj3
{
    public class IdenticalityFilter : Filter
    {
        public IdenticalityFilter(byte shift, float? divider) : base(shift, divider)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    M[i, j] = 0;
                }
            }
            M[1, 1] = 1;
        }
    }
}
