using System;

public class Problem70
{
    // public static void Main()
    // {
    //     Problem70 pb = new Problem70();
    //     Console.WriteLine(pb.ClimbStairs(6));
    // }

    public int ClimbStairs(int n)
    {
        if (n == 0) return 0;
        int previous = 1;
        int current = 1;
        int temp;
        for (int i = 2; i <= n; i++)
        {
            temp = current;
            current += previous;
            previous = temp;
        }

        return current;
    }
}