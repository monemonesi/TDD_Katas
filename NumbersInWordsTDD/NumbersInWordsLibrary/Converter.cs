﻿using System;
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
                return Convert_From0To19_ToWords(input);
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
        public string Convert_From0To19_ToWords(int input)
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

        
    }
}