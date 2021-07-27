using System;

namespace Text
{
    ///<summary>Class for string methods</summary>
    public class Str
    {
        ///<summary>Checks a string if it is a palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            string rev;
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = s.Equals(rev, StringComparison.InvariantCultureIgnoreCase);
         if (b == true) 
         {
            return true;
         } 
         else 
         {
            return false;
         }
        }
    }
}
