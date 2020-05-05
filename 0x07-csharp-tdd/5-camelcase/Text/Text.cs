using System;

namespace Text
{
    /// <summary>Class with string manipulation methods</summary>
    public class Str
    {
        /// <summary>Count how many words are in a string</summary>
        public static int CamelCase(string s)
        {
            if (s.Length == 0 || s == "")
                return 0;
            int count = 1;
            for (int i = 1; i < s.Length - 1; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    count++;
            }
            return count;  
        }
    }
}
