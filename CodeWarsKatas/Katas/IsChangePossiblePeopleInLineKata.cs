using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class IsChangePossiblePeopleInLineKata
    {
        public static string Tickets(int[] peopleInLine)
        {
            bool isPossible = false;
            int billCounter25 = 0;
            int billCounter50 = 0;
            string hasChange = "";

            if (peopleInLine[0] != 25)
            {
                isPossible = false;
            }
            else
            {
                isPossible = true;

                for (int i = 0; i < peopleInLine.Length && isPossible; i++)
                {

                    switch (peopleInLine[i])
                    {

                        case 100:

                            if (billCounter50 >= 1 && billCounter25 >= 1)
                            {
                                billCounter50--;
                                billCounter25--;
                                isPossible = true;
                                break;
                            }
                            else if (billCounter25 >= 3)
                            {
                                billCounter25 -= 3;
                                isPossible = true;
                                break;
                            }
                            else
                            {
                                isPossible = false;
                                break;
                            }

                        case 50:

                            if (billCounter25 >= 1)
                            {
                                billCounter25--;
                                billCounter50++;
                                isPossible = true;
                                break;
                            }
                            else
                            {
                                isPossible = false;
                                break;
                            }

                        case 25:

                            billCounter25++;
                            isPossible = true;
                            break;

                        default:
                            isPossible = false;
                            break;
                    }
                }
            }

            hasChange = isPossible ? "YES" : "NO";

            return hasChange;
        }
    }
}
