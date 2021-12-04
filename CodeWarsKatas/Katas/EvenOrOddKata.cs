using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class EvenOrOddKata
    {
        public static string EvenOrOdd(int number)
        {
            if (number % 2 != 0)
            {
                return "Odd";
            }

            else
            {
                return "Even";
            }
        }
    }
}
