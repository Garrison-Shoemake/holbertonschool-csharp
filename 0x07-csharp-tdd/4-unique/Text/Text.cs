using System;

namespace Text
{
    ///<summary>Class for string methods</summary>
    public class Str
    {
        ///<summary>Checks for first unique character</summary>
        public static int UniqueChar(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                char j = s[i];
                if (s.IndexOf(j, i + 1) == -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
