using System;
using System.Linq;

public class Problem16
{
    // public static void Main()
    // {
    //     Problem16 pb = new Problem16();
    //     Console.WriteLine(pb.ThreeSumClosest(new []{4,0,5,-5,3,3,0,-4,-5},-2));
    // }
    
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        int minValue = Int32.MaxValue;
        int sum = 0;
        int temp = 0;
        for (int i = 0; i < nums.Length-2; i++)
        {
            int left = i + 1;
            int right = nums.Length - 1;
            int numsi = nums[i];
            while (left<right)
            {
                //Console.WriteLine(numsi + " " +nums[left] + " " + nums[right]);
                temp =  Math.Abs(target- (numsi + nums[left] + nums[right]));
                if (temp <= minValue)
                {
                    //Console.WriteLine(numsi + "========== " +nums[left] + " " + nums[right]);
                    minValue = Math.Min(temp, minValue);
                    sum = numsi + nums[left] + nums[right];
                }
                if (numsi + nums[left] + nums[right] > target) right--;
                else left++;
            }
        }
        
        return sum;
    }

    
}