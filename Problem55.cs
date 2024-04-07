using System;
public class Problem55
{
    // public static void Main()
    // {
    //     Problem55 pb = new Problem55();
    //     Console.WriteLine(pb.CanJump(new[] { 2, 3, 1, 1, 4 }));
    // }

    public bool CanJump(int[] nums)
    {
        bool[] jumpable = new bool[nums.Length];
        jumpable[0] = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (jumpable[i])
            {
                for (int j = 1; j <= nums[i]; j++)
                {
                    if (j + i >= nums.Length)break; 
                    jumpable[j+i] = true;
                }
            }
        }
        
        return jumpable[nums.Length-1];
    }
}