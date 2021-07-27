using System;

namespace Text
{
    ///<summary>String class has standard string functions</summary>
    public class Str
    {
        ///<summary>checks for the first non-repeating character in a string</summary>
        public static int UniqueChar(string s)
        {
            char unique = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i], i+1) == -1)
                {
                    unique = s[i];
                    break;
                }
            }
            return unique;
        }
    }
}
