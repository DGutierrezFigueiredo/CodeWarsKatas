using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class SortTheOddKata
    {
        public static int[] SortArray(int[] array)
        {
            List<int> oddNumsList = new List<int>();
            List<int> finalList = new List<int>();
            int indexCounter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddNumsList.Add(array[i]);
                }
            }

            oddNumsList.Sort();

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 != 0) && oddNumsList.Count > indexCounter)
                {
                    finalList.Add(oddNumsList.ElementAt(indexCounter));
                    indexCounter++;
                }
                else if ((array[i] % 2 != 0))
                {
                    continue;
                }
                else
                {
                    finalList.Add(array[i]);
                }

            }

            return finalList.ToArray();
        }
    }
}
