using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class YouOnlyNeedOneKata
    {
        public static bool Check(object[] a, object x)
        {
            bool contains = false;

            for (int i = 0; i < a.Length && contains == false; i++)
            {
                if (a[i].Equals(x))
                {
                    return contains = true;

                }

            }
            return contains;
        }
    }
}
