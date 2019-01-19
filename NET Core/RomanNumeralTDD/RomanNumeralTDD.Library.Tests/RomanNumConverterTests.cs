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

        [TestCase(0, "")]
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
        public void ToRoman_NumFromOneToNine(int num, string expected)
        {
            string result = converter.ToRoman(num);

            Assert.AreEqual(expected, result);
        }

        [TestCase(10,"X")]
        [TestCase(11,"XI")]
        [TestCase(15,"XV")]
        [TestCase(20,"XX")]
        [TestCase(33,"XXXIII")]
        [TestCase(44,"XLIV")]
        [TestCase(57,"LVII")]
        [TestCase(62,"LXII")]
        [TestCase(70,"LXX")]
        [TestCase(79,"LXXIX")]
        [TestCase(86,"LXXXVI")]
        [TestCase(90,"XC")]
        [TestCase(93,"XCIII")]
        public void ToRoman_NumFromTenTo99(int num, string expected)
        {
            string result = converter.ToRoman(num);

            Assert.AreEqual(expected, result);
        }

        [TestCase(100,"C")]
        [TestCase(102,"CII")]
        [TestCase(255, "CCLV")]
        [TestCase(300, "CCC")]
        [TestCase(499, "CDXCIX")]
        [TestCase(527, "DXXVII")]
        [TestCase(830, "DCCCXXX")]
        [TestCase(999, "CMXCIX")]
        public void ToRoman_NumFrom100To999(int num, string expected)
        {
            string result = converter.ToRoman(num);

            Assert.AreEqual(expected, result);
        }

        
    }
}