using System;
using System.Collections.Generic;
using System.Text;

namespace WrapWordTDD.Library
{
    public static class Wrapper
    {
        public static string Wrap(string text, int columnNumber)
        {
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }

            if(columnNumber >= text.Length)
            {
                return text;
            }

            else
            {
                string output =  string.Empty;
                int maxIndex = columnNumber - 1;
                if (text[maxIndex] == ' ')
                {
                    string subStringRight = text.Substring(columnNumber);

                    output = $"{text.Substring(0,maxIndex)}\n{Wrap(subStringRight, columnNumber)}";
                }
                else
                {
                    string subStringLeft = text.Substring(0, maxIndex);
                    int index = subStringLeft.LastIndexOf(' ');

                    string subStringRight = text.Substring(index+1);
                    
                    output = $"{text.Substring(0,index)}\n{Wrap(subStringRight, columnNumber)}";
                }
                        
                return output;
            }

        }//End Wrap Method
    }
}
