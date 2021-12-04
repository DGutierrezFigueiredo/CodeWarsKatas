using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TwiceLinearKata
    {
        public static int DblLinear(int n)
        {
            List<int> listOfNumbers = new List<int>();

            listOfNumbers.Add(1);

            for (int i = 1; i < n * 5; i++)
            {
                listOfNumbers.AddRange(new List<int>() { (2 * listOfNumbers.ElementAt(i - 1)) + 1, (3 * listOfNumbers.ElementAt(i - 1)) + 1 });
            }

            listOfNumbers = listOfNumbers.Distinct().OrderBy(num => num).ToList();

            return listOfNumbers.ElementAt(n);
        }
    }
}
