using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Operations class with standard arithmetic</summary>
    public class Operations
    {
        ///<summary>Finds the highest integet in a list</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return 0;
            }
            nums.Sort();
            return nums[nums.Count - 1];
        }
    }
}
