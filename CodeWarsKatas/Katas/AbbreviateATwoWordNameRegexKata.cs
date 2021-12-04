using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class AbbreviateATwoWordNameRegexKata
    {
        public static string AbbrevName(string name)
        {
            string pattern = @"(^[A-Za-z0-9])([A-Za-z0-9]+)?\s?([A-Za-z0-9])([A-Za-z0-9]+)?$";
            string replacement = "$1.$3";
            return Regex.Replace(name.ToUpper(), pattern, replacement);
        }
    }
}
