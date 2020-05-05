using System;
using System.Collections.Generic;

namespace Text
{
     /// <summary>Class with string manipulation methods</summary>
    public class Str
    {
         /// <summary> returns the index of the first non-repeating character of a string</summary>
        public static int UniqueChar(string s)
        {
            if (s.Length == 0 || s == "")
                return -1;
            //s = s.ToLower();
            var set1 = new HashSet<char>();
            var set2 = new HashSet<char>();
	        foreach (var c in s)
            {
		        if (set1.Contains(c))
                    set2.Add(c);
                set1.Add(c);
            }
            for (var i = 0; i < s.Length; i++)
            {
                if (!set2.Contains(s[i]))
                    return i;
            }
            return -1;
        }
    }
}
