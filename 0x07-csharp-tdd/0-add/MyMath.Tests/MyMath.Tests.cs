using NUnit.Framework;

namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int test_result = Operations.Add(1, 1);
            Assert.AreEqual(2, test_result);
        }
    }
}