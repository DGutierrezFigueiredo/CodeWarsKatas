using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class OppositesAttractKata
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }
    }
}
