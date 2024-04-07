using System;

public class Problem27
{
    // public static void Main()
    // {
    //     Problem27 pb = new Problem27();
    //     Console.WriteLine(pb.RemoveElement(new[] { 2 }, 3));
    // }

    public int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;
        int left = 0;
        int right = nums.Length - 1;
        int valCount = 0;
        while (left < right)
        {
            if (nums[left] != val)
            {
                left++;
                continue;
            }

            if (nums[right] == val)
            {
                right--;
                valCount++;
                continue;
            }

            nums[left] = nums[right];
            right--;
            valCount++;
        }

        return nums.Length - valCount;
    }
}