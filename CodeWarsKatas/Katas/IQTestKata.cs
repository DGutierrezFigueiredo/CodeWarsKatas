using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsKatas.Katas
{
    public static class IQTestKata
    {
        public static int Test(string numbers)
        {
            string[] arrayOfNumbers = numbers.Split(' ');
            int counter = 0;
            int oddCounter = 0;
            int evenCounter = 0;
            int result = 0;
            int[] numbersInString = new int[arrayOfNumbers.Length];

            foreach (string number in arrayOfNumbers)
            {
                numbersInString[counter] = int.Parse(number);
                if (numbersInString[counter] % 2 == 0)
                {
                    arrayOfNumbers[counter] = "Even";
                }
                else
                {
                    arrayOfNumbers[counter] = "Odd";
                }
                counter++;
            }
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (arrayOfNumbers[i] == "Even")
                {
                    evenCounter += 1;
                }
                else
                {
                    oddCounter += 1;
                }
            }

            if (evenCounter > oddCounter)
            {

                for (int index = 0; index < arrayOfNumbers.Length; index++)
                {
                    if (arrayOfNumbers[index] == "Odd")
                    {
                        result = index + 1;

                    }

                }
            }
            else
            {
                for (int index = 0; index < arrayOfNumbers.Length; index++)
                {
                    if (arrayOfNumbers[index] == "Even")
                    {
                        result = index + 1;

                    }

                }

            }
            return result;

        }
    }
}
