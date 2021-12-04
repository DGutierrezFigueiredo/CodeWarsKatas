using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class BreakCamelCaseKata
    {
        public static string BreakCamelCase(string str)
        {
            StringBuilder builder = new StringBuilder();

            foreach (char c in str)
            {
                if (char.IsUpper(c) && builder.Length > 0)
                {
                    builder.Append(' ');
                }
                builder.Append(c);
            }

            str = builder.ToString();

            return str;
        }
    }
}
