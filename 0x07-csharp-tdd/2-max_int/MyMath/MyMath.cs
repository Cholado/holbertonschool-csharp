using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>Performs mathamatical operations on inputs.</summary>
    public class Operations
    {
        ///<summary>Finds the Max value in a list of integers.</summary>
        public static int Max(List<int> nums)
        {
            int num = 0;
            if (nums.Count != 0)
            {
                nums.Sort();
                num = nums[nums.Count - 1];
            }
            return (num);
        }
    }
}
