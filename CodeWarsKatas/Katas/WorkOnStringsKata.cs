using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeWarsKatas.Katas
{
   
    public static class WorkOnStringsKata
    {
        public static string workOnStrings(string a, string b)
        {
            bool isUpper;
            int letterRepetitionTally = 0;
            char[] stringAToArray = a.ToCharArray();
            char[] stringBToArray = b.ToCharArray();
            char[] newAToArray = new char[stringAToArray.Length];
            char[] newBToArray = new char[stringBToArray.Length];

            for (int i = 0; i < stringAToArray.Length; i++)
            {
                isUpper = char.IsUpper(stringAToArray[i]);
                letterRepetitionTally = stringBToArray.Count(letter =>
                                        char.ToUpperInvariant(letter).Equals(char.ToUpperInvariant(stringAToArray[i])));

                if (letterRepetitionTally % 2 == 0)
                {
                    newAToArray[i] = stringAToArray[i];
                }
                if (isUpper && letterRepetitionTally % 2 != 0)
                {
                    newAToArray[i] = char.ToLower(stringAToArray[i]);
                }
                if (!isUpper && letterRepetitionTally % 2 != 0)
                {
                    newAToArray[i] = char.ToUpper(stringAToArray[i]);
                }

                letterRepetitionTally = 0;
            }

            for (int i = 0; i < stringBToArray.Length; i++)
            {
                isUpper = char.IsUpper(stringBToArray[i]);
                letterRepetitionTally = stringAToArray.Count(letter =>
                                        char.ToUpperInvariant(letter).Equals(char.ToUpperInvariant(stringBToArray[i])));

                if (letterRepetitionTally % 2 == 0)
                {
                    newBToArray[i] = stringBToArray[i];
                }
                if (isUpper && letterRepetitionTally % 2 != 0)
                {
                    newBToArray[i] = char.ToLower(stringBToArray[i]);
                }
                if (!isUpper && letterRepetitionTally % 2 != 0)
                {
                    newBToArray[i] = char.ToUpper(stringBToArray[i]);
                }

                letterRepetitionTally = 0;
            }

            string newA = new string(newAToArray);
            string newB = new string(newBToArray);

            return newA + newB;
        }
    }
}
