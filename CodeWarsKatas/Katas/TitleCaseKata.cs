using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TitleCaseKata
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            string titleString = title.ToLower();
            string[] arrayOfTitleStrings = titleString.Split(' ');

            if (minorWords == null) minorWords = "";

            string[] arrayOfMinorWords = minorWords.Split(' ');

            if (string.IsNullOrEmpty(title))
            {
                return String.Empty;
            }

            for (int i = 0; i < arrayOfTitleStrings.Length; i++)
            {
                if (arrayOfTitleStrings[i].Length < 1)
                {
                    arrayOfTitleStrings[i] = arrayOfTitleStrings[i].ToUpper();
                }

                arrayOfTitleStrings[i] = arrayOfTitleStrings[i].Substring(0, 1).ToUpper() + arrayOfTitleStrings[i].Substring(1);

                if (arrayOfTitleStrings != null && arrayOfMinorWords != null)
                {
                    foreach (string str in arrayOfMinorWords)
                    {
                        if (arrayOfTitleStrings[i].ToLowerInvariant() == str.ToLowerInvariant() && i != 0)
                        {
                            arrayOfTitleStrings[i] = str.ToLower();
                        }
                    }
                }

            }

            title = string.Join(" ", arrayOfTitleStrings);

            return title;
        }
    }
}
