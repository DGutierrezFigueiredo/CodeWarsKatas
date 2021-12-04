using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class BestMatchKata
    {
        public static int BestMatch(int[] goals1, int[] goals2)
        {
            List<int> gameResultList = new List<int>();
            int bestMatchB = 0;

            for (int i = 0; i < goals1.Length; i++)
            {
                gameResultList.Add(goals1[i] - goals2[i]);
            }

            int minMatchResult = gameResultList.Min();
            List<int> minMatchResultIndex = new List<int>();

            if (gameResultList.Where(result => result.Equals(minMatchResult)).Count() > 1)
            {
                for (int i = 0; i < gameResultList.Count; i++)
                {
                    if (gameResultList[i] == minMatchResult)
                    {
                        minMatchResultIndex.Add(i);
                    }

                }

                bool isFirstIteration = true;

                for (int i = 0; i < minMatchResultIndex.Count; i++)
                {

                    if (goals2[minMatchResultIndex[i]] > goals2[bestMatchB] || isFirstIteration)
                    {
                        bestMatchB = minMatchResultIndex[i];
                        isFirstIteration = false;
                    }
                }

                return bestMatchB;
            }

            return gameResultList.IndexOf(minMatchResult);
        }
    }
}
