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
            if (num <= 9)
            {
                return ConvertNumberFrom0To9(num);
            }
            else if (num <= 99)
            {
                return ConvertNumberFrom10To99(num);
            }
            else if(num <= 999)
            {
                return ConvertNumberFrom100To999(num);
            }

            return String.Empty;
        }

        /// <summary>
        /// Convert to romans all the number between 100 and 999
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string ConvertNumberFrom100To999(int num)
        {
            int tens = num % 100;
            int hundreds = num - tens;

            string romanHundreds = string.Empty;

            switch (hundreds)
            {
                case 100:
                    romanHundreds = "C";
                    break;
                case 200:
                    romanHundreds = "CC";
                    break;
                case 300:
                    romanHundreds = "CCC";
                    break;
                case 400:
                    romanHundreds = "CD";
                    break;
                case 500:
                    romanHundreds = "D";
                    break;
                case 600:
                    romanHundreds = "DC";
                    break;
                case 700:
                    romanHundreds = "DC";
                    break;
                case 800:
                    romanHundreds = "DCCC";
                    break;
                case 900:
                    romanHundreds = "CM";
                    break;
                default:
                    break;
            }

            romanHundreds += ConvertNumberFrom10To99(tens);

            return romanHundreds;
        }

        /// <summary>
        /// Convert to romnans all the numbers between 10 and 99
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string ConvertNumberFrom10To99(int num)
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

            romanTens += ConvertNumberFrom0To9(units);

            return romanTens;
        }

        /// <summary>
        /// Convert to roman all the numbers between 0 and 9
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string ConvertNumberFrom0To9(int num)
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
