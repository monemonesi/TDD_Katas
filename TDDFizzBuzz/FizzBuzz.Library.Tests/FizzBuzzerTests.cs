using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void GetValue_StandardReturnInput(
            [Values(1,2,4,7,8,11,13,14,16,17,19)] int input)
        {
            //int input = 1;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void GetValue_WhenDivBy3ReturnFizz(
            [Values(3,6,9,12,18)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void GetValue_When5ReturnBuzz(
            [Values(5,10,20,25,35,40,50)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void GetValue_WhenDivBy3And5ReturnFizzBuzz(
            [Values(15,30,45,60,75,90)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }

        [Test]
        public void GetValue_BoundaryWhen100ReturnFizzBuzz()
        {
            int input = 100;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

    }
}
