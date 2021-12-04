using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TwiceAsOldKata
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            return Math.Abs(dadYears - 2 * sonYears);
        }
    }
}
