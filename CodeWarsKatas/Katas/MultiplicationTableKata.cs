using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class MultiplicationTableKata
    {
        public static int[,] MultiplicationTable(int size)
        {
            int[,] result = new int[size, size];
            int counter = 0;

            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {

                    if (i == 0)
                    {
                        result[i, j] = j + 1;
                    }
                    else
                    {
                        result[i, j] = result[i - counter, j] * (i + 1);
                    }
                }
                counter++;
            }

            return result;

        }
    }
}
