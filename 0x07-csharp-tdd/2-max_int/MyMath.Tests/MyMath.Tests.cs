using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void MaxAtEnd()
        {
            List<int> test = new List<int>() {0, 1, 2, 100};
            int result = Operations.Max(test);
            Assert.AreEqual(result, 100);
        }
        [Test]
        public void MaxAtBeginning()
        {
            List<int> test = new List<int>() {100, 1, 2, 0};
            int result = Operations.Max(test);
            Assert.AreEqual(result, 100);
        }
        [Test]
        public void MaxInMiddle()
        {
            List<int> test = new List<int>() {0, 100, 1, 2};
            int result = Operations.Max(test);
            Assert.AreEqual(result, 100);
        }
        [Test]
        public void MaxWithNegative()
        {
            List<int> test = new List<int>() {0, 100, -1, -2};
            int result = Operations.Max(test);
            Assert.AreEqual(result, 100);
        }
        [Test]
        public void EmptyList()
        {
            List<int> test = new List<int>() {};
            int result = Operations.Max(test);
            Assert.AreEqual(result, 0);
        }
    }
}