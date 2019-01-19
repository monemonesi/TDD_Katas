using System;

namespace RomanNumeralTDD.Library
{
    /// <summary>
    /// Convert integer arab number to roman
    /// </summary>
    public class RomanNumConverter
    {
        /// <summary>
        /// 
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
                return ConvertNumLessThenTen(num);
            }

        }

        private static string ConvertNumLessThenTen(int num)
        {
            switch (num)
            {
                case 0:
                    return Constants.ErrorMessageForZero;
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
                case 10:
                    return "X";
            }

            return String.Empty;
        }
    }
}
