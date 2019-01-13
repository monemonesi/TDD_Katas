using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInWordsLibrary.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Converter converter;

        [SetUp]
        public void Seup()
        {
            converter = new Converter();
        }

        #region TestCase_0To19
        [TestCase(0, "zero")]
        [TestCase(1, "one")]
        [TestCase(2, "two")]
        [TestCase(3, "three")]
        [TestCase(4, "four")]
        [TestCase(5, "five")]
        [TestCase(6, "six")]
        [TestCase(7, "seven")]
        [TestCase(8, "eight")]
        [TestCase(9, "nine")]
        [TestCase(10, "ten")]
        [TestCase(11, "eleven")]
        [TestCase(12, "twelve")]
        [TestCase(13, "thirteen")]
        [TestCase(14, "fourteen")]
        [TestCase(15, "fifteen")]
        [TestCase(16, "sixteen")]
        [TestCase(17, "seventeen")]
        [TestCase(18, "eighteen")]
        [TestCase(19, "nineteen")]
        public void ConvertInWords_0_to_19(int input, string expected)
        {
            string output = converter.ConvertToWords(input);

            Assert.AreEqual(expected, output);
        }
        #endregion


        #region TestCase 20To99
        [TestCase(20, "twenty")]
        [TestCase(21,"twenty-one")]
        [TestCase(30, "thirty")]
        [TestCase(35,"thirty-five")]
        [TestCase(40, "fourty")]
        [TestCase(42, "fourty-two")]
        [TestCase(50, "fifty")]
        [TestCase(53, "fifty-three")]
        [TestCase(60, "sixty")]
        [TestCase(64, "sixty-four")]
        [TestCase(70, "seventy")]
        [TestCase(79, "seventy-nine")]
        [TestCase(80, "eighty")]
        [TestCase(88, "eighty-eight")]
        [TestCase(90, "ninety")]
        [TestCase(97, "ninety-seven")]
        public void ConvertInWords_20_To_99(int input, string expected)
        {
            string output = converter.ConvertToWords(input);

            Assert.AreEqual(expected, output);
        }
        #endregion

        #region TestCase 100To999
        [TestCase(100, "one hundred")]
        [TestCase(105, "one hundred five")]
        [TestCase(200, "two hundred")]
        [TestCase(500, "five hundred")]
        [TestCase(512, "five hundred twelve")]
        [TestCase(700, "seven hundred")]
        [TestCase(750, "seven hundred fifty")]
        [TestCase(900, "nine hundred")]
        [TestCase(999, "nine hundred ninety-nine")]
        public void ConvertInWords_100_To_999(int input, string expected)
        {
            string output = converter.ConvertToWords(input);

            Assert.AreEqual(expected, output);
        }
        #endregion
    }
}
