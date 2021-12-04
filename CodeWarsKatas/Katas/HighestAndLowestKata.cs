using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class HighestAndLowestKata
    {
        public static string HighAndLow(string numbers)
        {
            string[] numbersArr = numbers.Split(' ');
            List<int> numbersList = new List<int>();

            for (int i = 0; i < numbersArr.Length; i++)
            {
                numbersList.Add((int.Parse)(numbersArr[i]));
            }

            numbers = numbersList.Max().ToString() + " " + numbersList.Min();

            return numbers;
        }
    }
}
