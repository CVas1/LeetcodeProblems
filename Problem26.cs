using System;

public class Problem26
{
    // public static void Main()
    // {
    //     Problem26 pb = new Problem26();
    //     Console.WriteLine(pb.RemoveDuplicates(new[] { 3, 4, 6, 7, 7, 8, 8, 9, 10 }));
    // }

    public int RemoveDuplicates(int[] nums)
    {
        int count = 0;
        int tempVal = Int32.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            int numsi = nums[i];
            if (numsi != tempVal)
            {
                nums[count] = numsi;
                count++;
                tempVal = numsi;
            }
        }

        return count;
    }
}