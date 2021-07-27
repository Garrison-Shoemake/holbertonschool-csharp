using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestRegularDivision()
        {
            int[,] test = {{2, 4}, {6,8}, {10,12}};
            int[,] result = Matrix.Divide(test, 2);
            Assert.AreEqual(result, new int[,]{{1,2}, {3,4}, {5,6}});
        }
        [Test]
        public void TestNullDivision()
        {
            int[,] test = null;
            int[,] result = Matrix.Divide(test, 3);
            Assert.AreEqual(result, null);
        }
    }
}