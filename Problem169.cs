using System;

public class Problem169
{
    // public static void Main()
    // {
    //     Problem169 pb = new Problem169();
    //     Console.WriteLine(pb.MajorityElement(new[] { 3, 2, 3 }));
    // }
    public int MajorityElement(int[] nums)
    {
        int major = 0;
        int counter = 0;
        foreach (int num in nums)
        {
            if (counter == 0)
            {
                major = num;
                counter = 1;
            }
            else if (major == num)
            {
                counter++;
            }
            else
            {
                counter--;
            }
        }

        return major;
    }
}