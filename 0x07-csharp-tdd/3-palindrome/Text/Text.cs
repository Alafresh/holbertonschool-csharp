using System;

namespace Text
{
    /// <summary>Class with string manipulation methods</summary>
    public class Str
    {
        /// <summary> returns True if a string is a palindrome or False if it’s not</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == "" || s.Length == 0)
                return true;

            s = s.Replace(" ", "");
            s = s.Replace(",", "");
            s = s.Replace(".", "");
            s = s.Replace(";", "");
            s = s.Replace(":", "");
            s = s.ToLower();
            string first = s.Substring(0, s.Length / 2);
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}
