using System;

namespace Text
{
///<summary>Class for string functions</summary>
    public class Str
    {
        ///<summary>Finds how many words are in a string</summary>
        public static int CamelCase(string s)
        {
            int count = 0;
            int index = 0;

            try
            {
                while (index < s.Length)
                {
                    if (char.IsUpper(s[index]) == true)
                    {
                        count++;
                    }
                    index++;
                }
                return count + 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
