using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class IsThatATriangleKata
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            int[] arrayOfTriangle = new int[] { a, b, c };
            int sideC = arrayOfTriangle.Max();
            int sideB = arrayOfTriangle.Min();
            int[] arrSideCAndSideB = new int[] { arrayOfTriangle.Max(), arrayOfTriangle.Min() };
            int[] arrSideA = arrayOfTriangle.Except(arrSideCAndSideB).ToArray();
            int sideA = arrSideA[0];

            if (sideB + sideA > sideC)
            {
                return true;
            }

            return false;
        }
    }
}
