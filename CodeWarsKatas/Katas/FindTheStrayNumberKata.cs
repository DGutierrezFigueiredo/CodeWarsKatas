using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class FindTheStrayNumberKata
    {
        public static int Stray(int[] numbers)
        {
            int smallNumber = numbers.Min();
            int greatNumber = numbers.Max();
            int strayNumber = 0;
            int minCounter = 0;
            int maxCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == smallNumber)
                {
                    minCounter++;
                }
                else
                {
                    maxCounter++;
                }
                if (minCounter > maxCounter)
                {
                    strayNumber = greatNumber;
                }
                else
                {
                    strayNumber = smallNumber;
                }

            }

            return strayNumber;

        }
    }
}
