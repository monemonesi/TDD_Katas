using System;
using System.Collections.Generic;
using System.Text;

namespace DIamondTDD.Library
{
    public static class Diamond
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Create(char selectedLetter)
        {
            string output = string.Empty;

            char letter = char.ToUpper(selectedLetter);

            int letterId = Alphabet.IndexOf(letter);

            //Upper half of diamond
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

        private static string CreateFirstLine(int letterId, int currentLine)
        {
            return $"{CreateLeftSpaces(letterId, currentLine)}A\n";
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

        private static string CreateLine(int letterId, int currentLine)
        {

            return $"{CreateLeftSpaces(letterId, currentLine)}" +
                    $"{Alphabet[currentLine]}" +
                    $"{CreateCentralSpaces(letterId, currentLine)}" +
                    $"{Alphabet[currentLine]}\n";

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
