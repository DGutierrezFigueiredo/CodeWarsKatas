using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class WhatIsBetweenKata
    {
        public static int[] Between(int a, int b)
        {
            List<int> numbersBetweenList = new List<int>();
            int numberOfElements = 0;

            numberOfElements = a < 0 && b < 0 ? (Math.Abs(a) - Math.Abs(b)) : (Math.Abs(a) + Math.Abs(b));

            if (a > 0 && b > 0) { numberOfElements = b - a; }

            for (int i = 0; i <= numberOfElements; i++)
            {
                numbersBetweenList.Add(a + i);
            }

            return numbersBetweenList.ToArray();
        }
    }
}
