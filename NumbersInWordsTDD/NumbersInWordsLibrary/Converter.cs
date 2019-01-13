using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInWordsLibrary
{
    public class Converter
    {
        /// <summary>
        /// Convert the input numbers to words
        /// </summary>
        /// <param name="input"> positive number to convert</param>
        /// <returns>number expressed in words</returns>
        public string ConvertToWords(int input)
        {
            if (input >= 0 && input <= 19)
            {
                return ConvertToWords_0To19(input);
            }
            else if (input <= 99)
            {
                return ConvertToWords_20To99(input);
            }
            else
            {
                return null;
            }


        }

        

        /// <summary>
        /// Convert number from 0 to 19.
        /// Explicit function because ther is no pattern for these
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ConvertToWords_0To19(int input)
        {
            switch (input)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
            }
            return null;
        }


        /// <summary>
        /// Convert numbers from 20 To 99.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private string ConvertToWords_20To99(int input)
        {
            int latestNumber = input%10;
            int tens = input - latestNumber;

            return TwoWordsNumbers(tens, latestNumber);
        }

        /// <summary>
        /// Convert all the two words numbers
        /// </summary>
        /// <param name="first">represent the tens</param>
        /// <param name="second"> represent the units</param>
        /// <returns></returns>
        private string TwoWordsNumbers(int first, int second)
        {
            string numberInWords = string.Empty;
            numberInWords += ConvertTens(first);

            if (second != 0)
            {
                numberInWords += "-";
                numberInWords += ConvertToWords_0To19(second);
            }
            
            return numberInWords;
        }

        /// <summary>
        /// Convert the tens in words
        /// </summary>
        /// <param name="tens"></param>
        /// <returns></returns>
        private static string ConvertTens(int tens)
        {
            switch (tens)
            {
                case 20:
                    return "twenty";
                case 30:
                    return "thirty";
                case 40:
                    return "fourty";
                case 50:
                    return "fifty";
                case 60:
                    return "sixty";
                case 70:
                    return "seventy";
                case 80:
                    return "eighty";
                case 90:
                    return "ninety";
            }

            return string.Empty;
        }
    }
}
