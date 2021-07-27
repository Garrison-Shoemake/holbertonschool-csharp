using System;

namespace Text
{
    ///<summary>Class for string methods</summary>
    public class Str
    {
        ///<summary>Checks for first unique character</summary>
        public static int UniqueChar(string s)
        {
            char unique = new char();
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i], i + 1) == -1)
                {
                    unique = s[i];
                    break;
                }
            }
            return unique;
        }
    }
}
