using System;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary>Class for string methods</summary>
    public class Str
    {
        ///<summary>Checks a string if it is a palindrome</summary>
        public static bool IsPalindrome(string s)
        {
            string test = s.ToLower();
            string nopunct = Regex.replace(test, @"[,.:; ]", "");
            int i = 0;
            int j = nopunct.Length - 1;

            while (i <j)
            {
                if (nopunct[i] != nopunct[j])
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
    }
}
