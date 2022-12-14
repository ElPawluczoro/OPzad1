using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    internal class Speeds
    {
        public static float KnotsToMpS(float knots)
        {
            return knots * 0.51f;
        }

        public static float MpSToKnots(float mps)
        {
            return mps / 0.51f;
        }
    }
}
