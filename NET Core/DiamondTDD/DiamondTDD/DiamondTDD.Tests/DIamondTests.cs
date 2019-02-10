using DIamondTDD.Library;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {


        [TestCase('a',"A\n")]
        [TestCase('A',"A\n")]
        public void Create_A(char letter, string expected)
        {
            string result = Diamond.Create(letter);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Create_B()
        {
            string expected = " A\n" + "B B\n" + " A\n";

            string result = Diamond.Create('B');

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Create_C()
        {
            string expected = "  A\n" + " B B\n" + "C   C\n" + " B B\n" + "  A\n";

            string result = Diamond.Create('c');

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Create_D()
        {
            string expected = "   A\n" + "  B B\n" + " C   C\n" +"D     D\n"+
                              " C   C\n" + "  B B\n" + "   A\n";

            string result = Diamond.Create('D');

            Assert.AreEqual(expected, result);
        }
    }
}