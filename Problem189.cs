using System;

namespace Leetcode.LeetcodeProblems
{
    public class Problem189
    {
        // public static void Main()
        // {
        //     Problem189 pb = new Problem189();
        //     pb.Rotate(new []{1,2,3,4,5,6,7},3);
        // }
        public void Rotate(int[] nums, int k)
        { 
            int[] arr = new int[nums.Length];
            for (int i = 0; i <nums.Length ; i++)
            {
                arr[(i + k)  % nums.Length] = nums[i];
            }
            arr.CopyTo(nums,0);
        }
    }
}