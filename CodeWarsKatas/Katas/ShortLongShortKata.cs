using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class ShortLongShortKata
    {
        public static string Solution(string a, string b)
        {
            StringBuilder concat = new StringBuilder();
            int aLength = a.Length;
            int bLength = b.Length;

            if (aLength < bLength)
            {
                concat.Append(a + b + a);
                return concat.ToString();
            }

            return concat.Append(b + a + b).ToString();
        }
    }
}
