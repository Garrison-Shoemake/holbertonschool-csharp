using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]

        public void TestNullCheck()
        {
            result = Matrix.Divide(null, 5)
            Assert.IsNull(result);
        }
        public void TestRegularDivision()
        {
            int[,] matrix = {{2, 4}, {6,8}, {10,12}};
            int[,] result = matrix.Divide(matrix, 2);
            Assert.AreEqual(result, new int[,] {{1,2}, {3,4}, {5,6}});
        }
    }
}