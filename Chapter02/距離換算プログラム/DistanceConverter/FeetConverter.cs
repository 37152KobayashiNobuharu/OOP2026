using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    public static class FeetConverter
    {
        private static readonly double ratio = 0.3048;  //定数
        public static double FromMeter(double meter)
        {
            return meter / ratio;
        }
        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }
    }
}
