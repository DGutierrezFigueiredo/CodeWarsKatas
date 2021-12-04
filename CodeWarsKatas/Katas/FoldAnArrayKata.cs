using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class FoldAnArrayKata
    {
        public static int[] FoldArray(int[] array, int runs)
        {
            List<int> foldedList = new List<int>();
            List<int> auxiliaryList = array.ToList();

            for (int i = 0; i < runs; i++)
            {
                foldedList.AddRange(auxiliaryList);

                if (foldedList.Count % 2 == 0)
                {
                    foldedList.Clear();

                    for (int j = 0; j < auxiliaryList.Count / 2; j++)
                    {
                        foldedList.Add(auxiliaryList[j] + auxiliaryList[(auxiliaryList.Count - 1) - j]);

                    }

                    auxiliaryList.Clear();
                    auxiliaryList.AddRange(foldedList);
                    if (i < runs - 1) { foldedList.Clear(); }
                }
                else
                {
                    foldedList.Clear();

                    for (int j = 0; j <= (auxiliaryList.Count / 2); j++)
                    {
                        if (j == (auxiliaryList.Count / 2)) { foldedList.Add(auxiliaryList[j]); }
                        else
                        {
                            foldedList.Add(auxiliaryList[j] + auxiliaryList[(auxiliaryList.Count - 1) - j]);
                        }

                    }

                    auxiliaryList.Clear();
                    auxiliaryList.AddRange(foldedList);

                    if (i < runs - 1) { foldedList.Clear(); }

                }

            }
            return foldedList.ToArray();
        }
    }
}
