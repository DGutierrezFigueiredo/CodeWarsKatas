using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class TheIfFunctionKata
    {
        public static void If(bool condition, Action func1, Action func2)
        {
            if (condition)
            {
                func1();
            }
            else
            {
                func2();
            }
        }
    }
}
