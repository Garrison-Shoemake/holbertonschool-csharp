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
        public void PunctTest()
        {
            string test = "abcd, e dcba";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
        [Test]
        public void EmptyString()
        {
            string test = "";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
        [Test]
        public void SpaceTest()
        {
            string test = "abcd e dcba";
            Assert.IsTrue(Str.IsPalindrome(test));
        }
    }
}