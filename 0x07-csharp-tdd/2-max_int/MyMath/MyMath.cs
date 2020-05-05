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
            int result = nums[0];
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > result)
                    result = nums[i];
            }
            return result;
        }
    }
}
