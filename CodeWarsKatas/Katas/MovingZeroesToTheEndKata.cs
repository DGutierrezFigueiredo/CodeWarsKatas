using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class MovingZeroesToTheEndKata
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> numbersInArr = new List<int>();
            foreach (int number in arr)
            {
                if (number != 0)
                {
                    numbersInArr.Add(number);
                }

            }
            foreach (int number in arr)
            {
                if (number == 0)
                {
                    numbersInArr.Add(number);
                }
            }
            return numbersInArr.ToArray();

        }
    }
}
