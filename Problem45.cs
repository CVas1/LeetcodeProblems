using System;


public class Problem45
{
    // public static void Main()
    // {
    //     Problem45 pb = new Problem45();
    //     Console.WriteLine(pb.Jump(new[] { 2, 3, 1, 1, 4 }));
    // }

    public int Jump(int[] nums)
    {
        int[] jumpable = new int[nums.Length];
        jumpable[0] = 1;
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (jumpable[i]>=1)
            {
                for (int j = 1; j <= nums[i]; j++)
                {
                    if (j + i >= nums.Length)break;
                    if (jumpable[j + i] == 0) jumpable[j + i] = jumpable[i]+1;
                    else jumpable[j+i] = Math.Min(jumpable[j+i],jumpable[i]+1);
                }
            }
        }
        
        return jumpable[nums.Length-1]-1;
    }
}