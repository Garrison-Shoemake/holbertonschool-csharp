using System;

namespace Text
{
    ///<summary>Class for string methods</summary>
    public class Str
    {
        ///<summary>Checks for first unique character</summary>
        public static int UniqueChar(string s)
        {
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.IndexOf(s[i], i + 1) == -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
