using System;

namespace RomanNumeralTDD.Library
{
    /// <summary>
    /// Convert integer arab number to roman
    /// </summary>
    public class RomanNumConverter
    {
        /// <summary>
        /// Convert all ranges of numbers in roman number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public string ToRoman(int num)
        {
            if(num < 0)
            {
                return Constants.ErrorMessageForNegativeNum;
            }
            else
            {
                return FindRange(num);
            }

        }

        /// <summary>
        /// Find the range of the number num
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string FindRange(int num)
        {
            if (num < 10)
            {
                return ConvertNumberFromZeroToNine(num);
            }
            else if (num < 99)
            {
                return ConvertNumberFromTenToNintyNine(num);
            }

            return String.Empty;
        }

        /// <summary>
        /// Convert to romna all the numbers between 10 and 99
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string ConvertNumberFromTenToNintyNine(int num)
        {
            int units = num % 10;
            int tens = num - units;

            string romanTens = string.Empty;

            switch (tens)
            {
                case 10:
                    romanTens = "X";
                    break;
                case 20:
                    romanTens = "XX";
                    break;
                case 30:
                    romanTens = "XXX";
                    break;
                case 40:
                    romanTens = "XL";
                    break;
                case 50:
                    romanTens = "L";
                    break;
                case 60:
                    romanTens = "LX";
                    break;
                case 70:
                    romanTens = "LXX";
                    break;
                case 80:
                    romanTens = "LXXX";
                    break;
                case 90:
                    romanTens = "XC";
                    break;

                default:
                    break;
            }

            romanTens += ConvertNumberFromZeroToNine(units);

            return romanTens;
        }

        /// <summary>
        /// Convert to roman all the numbers between 0 and 9
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string ConvertNumberFromZeroToNine(int num)
        {
            switch (num)
            {
                case 0:
                    return String.Empty;
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    return string.Empty;
            }
        }
    }
}
