using System;

public class Problem69
{
    // public static void Main()
    // {
    //     Problem69 pb = new Problem69();
    //     Console.WriteLine(pb.MySqrt(2147483647));
    // }
    
    public int MySqrt(int x)
    {
        int pow = 0;
        while (pow*pow<=x && pow <= 46340)
        {
            pow++;
        }
        return pow-1;
    }
    
}