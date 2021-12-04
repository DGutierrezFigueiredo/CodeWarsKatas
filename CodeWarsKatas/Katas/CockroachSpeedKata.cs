using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class CockroachSpeedKata
    {
        public static int CockroachSpeed(double x)
        {
            int result = (int)Math.Floor(x * 27.78);
            return result;
        }
    }
}
