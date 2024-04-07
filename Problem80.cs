using System;


public class Problem80
{
    // public static void Main()
    // {
    //     Problem80 pb = new Problem80();
    //     Console.WriteLine(pb.RemoveDuplicates(new[] { 1, 1, 1 }));
    // }

    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2) return nums.Length;
        int count = 0;
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] == nums[i + 2]) continue;
            nums[count++] = nums[i];
        }
        nums[count++] = nums[nums.Length-2];
        nums[count++] = nums[nums.Length-1];
        return count;
    }
}