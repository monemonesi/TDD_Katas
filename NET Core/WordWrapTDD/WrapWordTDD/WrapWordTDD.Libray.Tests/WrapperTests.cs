using NUnit.Framework;
using WrapWordTDD.Library;

namespace Tests
{
    public class WrapperTests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        public void Wrapper_WhenEmpty_ReturnEmpty()
        {
            string output = Wrapper.Wrap("", 4);

            Assert.AreEqual(string.Empty, output);
        }

        [TestCase("text",7)]
        [TestCase("text",4)]
        [TestCase("a",1)]
        public void Wrapper_WhenNumberBiggerOrEqualThenStringLenght_ReturnString(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual(input, output);
        }

        [TestCase("text text",5)]
        public void Wrapper_WhenNumberIsOnWordEdge_SplitStringThere(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual("text\ntext", output);
        }

        [TestCase("text text text", 10)]
        public void Wrapper_WhenNumberIsOnWordEdge_SplitStringThere2(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual("text text\ntext", output);
        }

        [TestCase("text text", 7)]
        public void Wrapper_WhenNumberIsOnWord_SplitAtPreviousSpace(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual("text\ntext", output);
        }

        [TestCase("text text text", 12)]
        public void Wrapper_WhenNumberIsOnWord_SplitAtPreviousSpace2(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual("text text\ntext", output);
        }

        [TestCase("text text text", 5)]
        public void Wrapper_WhenMoreLinesAreNeeded_SplitMultipleLines(string input, int num)
        {
            string output = Wrapper.Wrap(input, num);

            Assert.AreEqual("text\ntext\ntext", output);
        }


    }
}