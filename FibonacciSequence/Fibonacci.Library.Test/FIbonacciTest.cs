using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci.Library.Test
{
    //0,1,1,2,3,5,8,13,21,34,55,89
    [TestFixture]
    public class FIbonacciTest
    {
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(3,2)]
        [TestCase(4,3)]
        [TestCase(5,5)]
        [TestCase(6,8)]
        [TestCase(11,89)]
        public void GenerateSequence_TestLatestNumber(int position,int expected)
        {
            int lastNumber = Fibonacci.GetValue(position);

            Assert.AreEqual(expected, lastNumber);
        }
    }
}
