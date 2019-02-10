using System;
using System.Collections.Generic;
using System.Text;

namespace DIamondTDD.Library
{
    public static class Diamond
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        /// <summary>
        /// Main function for create the diamond
        /// </summary>
        /// <param name="selectedLetter"></param>
        /// <returns></returns>
        public static string Create(char selectedLetter)
        {
            string output = string.Empty;

            char letter = char.ToUpper(selectedLetter);

            int letterId = Alphabet.IndexOf(letter);

            output = CreatUpperHalfOfDiamond(output, letterId);
            output = CreateLowerHalfOfDiamond(output, letterId);


            return output;
        }

        /// <summary>
        /// Create the upper half of the diamond, including the central line with the chosen letter
        /// </summary>
        /// <param name="output"></param>
        /// <param name="letterId"></param>
        /// <returns></returns>
        private static string CreatUpperHalfOfDiamond(string output, int letterId)
        {
            for (int i = 0; i <= letterId; i++)
            {
                if (i == 0)
                {
                    output += CreateFirstLine(letterId, i);
                }
                else
                {
                    output += CreateLine(letterId, i);
                }
            }

            return output;
        }

        /// <summary>
        /// Create the lower part of the diamond (without the central line)
        /// </summary>
        /// <param name="output"></param>
        /// <param name="letterId"></param>
        /// <returns></returns>
        private static string CreateLowerHalfOfDiamond(string output, int letterId)
        {
            for (int i = letterId-1; i >= 0; i--)
            {
                if (i == 0)
                {
                    output += CreateFirstLine(letterId, i);
                }
                else
                {
                    output += CreateLine(letterId, i);
                }
            }

            return output;
        }

        /// <summary>
        /// Create the first line (with only the A character)
        /// </summary>
        /// <param name="letterId"></param>
        /// <param name="currentLine"></param>
        /// <returns></returns>
        private static string CreateFirstLine(int letterId, int currentLine)
        {
            return $"{CreateLeftSpaces(letterId, currentLine)}A\n";
        }


        /// <summary>
        /// Create the standard line with the format: leftSpaces-Char-centralSpaces-Char\n
        /// </summary>
        /// <param name="letterId"></param>
        /// <param name="currentLine"></param>
        /// <returns></returns>
        private static string CreateLine(int letterId, int currentLine)
        {

            return $"{CreateLeftSpaces(letterId, currentLine)}" +
                    $"{Alphabet[currentLine]}" +
                    $"{CreateCentralSpaces(letterId, currentLine)}" +
                    $"{Alphabet[currentLine]}\n";

        }

        private static string CreateLeftSpaces(int letterId, int currentLine)
        {
            string leftSpaces = string.Empty;
            for (int j = 0; j < (letterId-currentLine); j++)
            {
                leftSpaces += " ";
            }
            return leftSpaces;
        }

        private static object CreateCentralSpaces(int letterId, int currentLine)
        {
            string centralSpaces = string.Empty;
            for (int j = 0; j < (currentLine * 2 -1); j++)
            {
                centralSpaces += " ";
            }
            return centralSpaces;
        }
    }
}
