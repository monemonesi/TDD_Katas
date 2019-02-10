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
                output += CreateLine(i);
            }


            return output;
        }

        private static string CreateLine(int i)
        {

            return Alphabet[i].ToString();
        }
    }
}
