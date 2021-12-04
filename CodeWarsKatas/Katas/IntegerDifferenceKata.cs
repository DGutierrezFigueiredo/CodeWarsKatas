using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class IntegerDifferenceKata
    {
        public static int IntDiff(int[] arr, int n)
        {
            int result = 0;

            if (n < 0) { return result = 0; }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Max(arr[i], arr[j]) - (Math.Min(arr[i], arr[j])) == n)
                    {
                        result++;
                    }
                }
            }
            return result;
        }
    }
}
