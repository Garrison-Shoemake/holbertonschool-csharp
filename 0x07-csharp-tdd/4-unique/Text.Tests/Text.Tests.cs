using NUnit.Framework;

namespace Text.Tests
{
    ///<summary>Class </summary>
    public class Tests
    {

        [Test]
        public void FirstChar()
        {
            string test = "abbccdd";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(result, 0);
        }
        [Test]
        public void LastChar()
        {
            string test = "bbccdda";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(result, 6);
        }
        [Test]
        public void MiddleChar()
        {
            string test = "bbaccdd";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void NoUniques()
        {
            string test = "bbaaccdd";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(result, -1);
        }
        [Test]
        public void EmptyString()
        {
            string test = "";
            int result = Str.UniqueChar(test);
            Assert.AreEqual(result, -1);
        }
    }
}