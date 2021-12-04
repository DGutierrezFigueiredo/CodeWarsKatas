using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class NotVerySecureRegexKata
    {
        public static bool Alphanumeric(string str)
        {
            bool isValid = false;
            string regexStr = @"\W+|[_]+|[ ]+|^$";

            isValid = Regex.IsMatch(str, regexStr) ? false : true;

            return isValid;
        }
    }
}
