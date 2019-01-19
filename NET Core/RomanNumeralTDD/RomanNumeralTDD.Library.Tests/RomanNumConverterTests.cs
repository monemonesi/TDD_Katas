using NUnit.Framework;
using RomanNumeralTDD.Library;

namespace Tests
{
    public class RomanNumConverterTests
    {
        private RomanNumConverter converter;

        [SetUp]
        public void Setup()
        {
            converter = new RomanNumConverter();
        }

        [TestCase(0, "Romans didn`t know how to say 0")]
        [TestCase(-15, "Please insert a positive number")]
        public void ToRoman_NumLessEqualThen0_ExpectedErrorString(int num, string expected)
        {
            string result = converter.ToRoman(num);

            Assert.AreEqual(expected, result);
        }

        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(9,"IX")]
        [TestCase(10,"X")]
        public void ToRoman_NumFormOneToTen(int num, string expected)
        {
            string result = converter.ToRoman(num);

            Assert.AreEqual(expected, result);
        }
    }
}