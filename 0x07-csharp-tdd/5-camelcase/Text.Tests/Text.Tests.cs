using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {

        [Test]
        public void OneWord()
        {
            string test = "word";
            int result = Str.CamelCase(test);
            Assert.AreEqual(result, 1);
        }
        [Test]
        public void TwWord()
        {
            string test = "wordWord";
            int result = Str.CamelCase(test);
            Assert.AreEqual(result, 2);
        }
        [Test]
        public void ManyWord()
        {
            string test = "wordWordWord";
            int result = Str.CamelCase(test);
            Assert.AreEqual(result, 3);
        }
        [Test]
        public void NoWord()
        {
            string test = "";
            int result = Str.CamelCase(test);
            Assert.AreEqual(result, 0);
        }
    }
}