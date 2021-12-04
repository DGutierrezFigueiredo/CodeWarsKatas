using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class ArrayDiffKata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> result = a.ToList();

            result.RemoveAll(num => b.ToList().Contains(num));

            return result.ToArray();
        }
    }
}
