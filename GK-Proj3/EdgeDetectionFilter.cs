using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GK_Proj3
{
    public class EdgeDetectionFilter: Filter
    {
        public EdgeDetectionFilter(byte shift, float? divider) : base(shift, divider)
        {
            M[0, 0] = 0;
            M[0, 1] = -1;
            M[0, 2] = 0;
            M[1, 0] = -1;
            M[1, 1] = 4;
            M[1, 2] = -1;
            M[2, 0] = 0;
            M[2, 1] = -1;
            M[2, 2] = 0;
        }
    }
}
