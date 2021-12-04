using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class HowLongToBuyACarKata
    {
        public static int[] HowManyMonthsCalculator(int startPriceOld, int startPriceNew, int savingPerMonth, double percentLossByMonth)
        {
            int[] result = new int[2];
            int months = 0;
            int i = 0;
            double startPriceOldIntoDouble = (double)startPriceOld;
            double startPriceNewIntoDouble = (double)startPriceNew;
            double savingPerMonthIntoDouble = 0;

            if (startPriceOldIntoDouble >= startPriceNewIntoDouble)
            {
                result[0] = 0;
                result[1] = (int)Math.Round(startPriceOldIntoDouble - startPriceNewIntoDouble);
            }
            else
            {
                while ((startPriceOldIntoDouble + savingPerMonthIntoDouble) <= startPriceNewIntoDouble)
                {

                    if ((startPriceOldIntoDouble + savingPerMonthIntoDouble) >= startPriceNewIntoDouble)
                    {
                        months = i;
                        result[0] = months;
                        result[1] = Math.Abs((int)Math.Round((startPriceOldIntoDouble + savingPerMonthIntoDouble) - startPriceNewIntoDouble));
                        break;
                    }

                    percentLossByMonth = PercentageCalculator(i, percentLossByMonth);
                    startPriceOldIntoDouble -= DepreciationEvaluator(startPriceOldIntoDouble, percentLossByMonth);
                    startPriceNewIntoDouble -= DepreciationEvaluator(startPriceNewIntoDouble, percentLossByMonth);

                    savingPerMonthIntoDouble += (double)savingPerMonth;

                    if ((startPriceOldIntoDouble + savingPerMonthIntoDouble) >= startPriceNewIntoDouble)
                    {
                        months = i + 1;
                        result[0] = months;
                        result[1] = Math.Abs((int)Math.Round((startPriceOldIntoDouble + savingPerMonthIntoDouble) - startPriceNewIntoDouble));
                        break;
                    }

                    i++;
                }
            }

            return result;
        }
        public static double PercentageCalculator(int i, double percentLossByMonth)
        {
            if (i > 0 && (i + 1) % 2 == 0)
            {
                return percentLossByMonth += 0.5;
            }

            return percentLossByMonth;
        }

        public static double DepreciationEvaluator(double carPrice, double percentLossByMonth)
        {
            carPrice -= carPrice * (1 - (percentLossByMonth / 100));
            return carPrice;
        }
    }
}
