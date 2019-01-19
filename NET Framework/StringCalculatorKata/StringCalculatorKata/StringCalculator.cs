using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public static string Add(string input)
        {
            return string.IsNullOrEmpty(input) ? "0" : AddNumbers(input);
        }

        private static string AddNumbers(string input)
        {
            List<String> allPossibleDelimeters = new List<string>() { ",", "\n" };

            bool hasSpecificDelimeters = input.StartsWith("//");
            if (hasSpecificDelimeters)
            {
                int index = input.IndexOf("\n", StringComparison.Ordinal) - 2;
                var specificDelimeter = input.Substring(2, index);
                allPossibleDelimeters.Add(specificDelimeter);
                var newDelimeters = allPossibleDelimeters.ToArray();
                return GetSum(input, newDelimeters);

            }
            else
            {
                var delimeters = allPossibleDelimeters.ToArray();
                return GetSum(input, delimeters);
            }

        }

        private static string GetSum(string input, string[] delimeters)
        {
            List<string> numbers = input.Split(delimeters, StringSplitOptions.None).ToList<string>();
            int output = AddParsedValues(numbers);
            return output.ToString();
        }

        private static int AddParsedValues(List<string> numbers)
        {
            int output = 0;
            foreach (string num in numbers)
            {
                int parsedNumber = 0;
                if (int.TryParse(num, out parsedNumber))
                {
                    if (Validate(parsedNumber))
                    {
                        output += parsedNumber;
                    }
                    
                }
            }

            return output;
        }

        private static bool Validate(int parsedNumber)
        {
            bool isValid = true;
            if (parsedNumber < 0)
            {
                isValid = false;
                throw new ArgumentException($"string contains {parsedNumber}. Negative not allowed");
            }
            if (parsedNumber > 1000)
            {
                isValid = false;
            }
            return isValid;
        }
    }
}
