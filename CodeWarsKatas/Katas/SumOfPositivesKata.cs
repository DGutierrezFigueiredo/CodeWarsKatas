using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class SumOfPositivesKata
    {
        public static int PositiveSum(int[] arr)
        {
            int sumOfNumbers = 0;
            List<int> listOfpositveNumbers = new List<int>();

            foreach (int number in arr)
            {
                if (number > 0)
                {
                    listOfpositveNumbers.Add(number);
                }

            }
            foreach (int number in listOfpositveNumbers)
            {

                sumOfNumbers += number;
            }
            if (arr.Length > 0)
            {
                return sumOfNumbers;
            }
            return 0;
        }
    }
}
