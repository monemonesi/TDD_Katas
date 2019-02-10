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
            }


            return output;
        }

        private static string CreateFirstLine(int letterId, int lineId)
        {
            return $"{LeftSpaces(letterId, lineId)}A\n";
        }

        private static string LeftSpaces(int letterId, int lineId)
        {
            string leftSpaces = string.Empty;
            for (int j = 0; j < (letterId-lineId); j++)
            {
                leftSpaces += " ";
            }
            return leftSpaces;
        }

        private static string CreateLine(int i)
        {

            return Alphabet[i].ToString();
        }
    }
}
