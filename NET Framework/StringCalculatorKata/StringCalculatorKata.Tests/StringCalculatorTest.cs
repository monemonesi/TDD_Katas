using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata.Tests
{
    [TestFixture]
    public class StringCalculatorTest
    {
        [Test]
        public void Add_WhenEmptyReturnZero()
        {
            string input = "";

            string output = StringCalculator.Add(input);

            Assert.AreEqual("0", output);
        }

        [TestCase("0")]
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("5")]
        [TestCase("10")]
        public void Add_WhenOneNumberReturnNumber(string input)
        {
            string output = StringCalculator.Add(input);

            Assert.AreEqual(input, output);
        }

        [TestCase("1,2","3")]
        [TestCase("0,2", "2")]
        [TestCase("10,2", "12")]
        [TestCase("1,10", "11")]
        [TestCase("1,0", "1")]
        [TestCase("0,0", "0")]
        public void Add_WheTwoNumbersReturnSum(string input, string expected)
        {

            string output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("1,2,3","6")]
        [TestCase("0,0,0", "0")]
        [TestCase("1,1,1,1,1,1", "6")]
        public void Add_WhenNDigitReturnSum(string input, string expected)
        {

            string output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("1\n1", "2")]
        [TestCase("1,2\n3","6")]
        public void Add_WhenNewLineBetweenNumReturnSum(string input, string expected)
        {

            string output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("//;\n1;2","3")]
        [TestCase("//-\n10-1","11")]
        [TestCase("//-\n10-1,9", "20")]
        public void Add_WhenDifferentDelimeterReturnSum(string input, string expected)
        {
            string output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);

        }

        [TestCase("1,-1", "-1")]
        [TestCase("//;;\n10;;-1,9", "-1")]
        public void Add_ThrowExceptionWhenNegativeNumberIsInserted(string input, string negNumber)
        {

            var exception = Assert.Throws<ArgumentException>(() => StringCalculator.Add(input));

            Assert.That(exception.Message, Is.EqualTo(string.Format($"string contains {negNumber}. Negative not allowed")));
        }

        [TestCase("2,1001","2")]
        [TestCase("1001,1001,1001","0")]
        public void Add_IgnoreNumbersBiggerThanOneThousand(string input, string expected)
        {
            var output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);
        }

        [TestCase("//;;\n10;;1,9", "20")]
        public void Add_DelimeterOfAnyLengthReturnSum(string input, string expected)
        {
            string output = StringCalculator.Add(input);

            Assert.AreEqual(expected, output);

        }


    }
}
