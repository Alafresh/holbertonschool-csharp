using System;
using System.Linq;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>Class with maths methods</summary>
    public class Operations
    {
        /// <summary>returns the max integer in a list of integers.</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            return nums.Max();
        }
    }
}
