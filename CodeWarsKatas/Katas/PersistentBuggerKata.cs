using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class PersistentBuggerKata
    {
        public static int Persistence(long n)
        {
            int counter = 0;
            long persistedNumber = 1;
            while (n >= 10)
            {
                string longToString = n.ToString();
                char[] myCharArray = longToString.ToCharArray();
                persistedNumber = 1;
                for (int i = 0; i < myCharArray.Length; i++)
                {
                    persistedNumber *= (long)char.GetNumericValue(myCharArray[i]);
                    n = persistedNumber;
                }

                counter++;

            }
            return counter;
        }
    }
}
