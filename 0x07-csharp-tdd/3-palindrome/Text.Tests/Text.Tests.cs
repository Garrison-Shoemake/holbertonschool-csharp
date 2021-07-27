using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void RegularPalindrome()
        {
            string test = "abcdedcba";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
        [Test]
        public void CaseTest()
        {
            string test = "aBcDedCbA";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
        [Test]
        public void PunctSpaceTest()
        {
            string test = "a, b, c, d, e, d, c, b, a";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
        [Test]
        public void EmptyString()
        {
            string test = "";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
    }
}