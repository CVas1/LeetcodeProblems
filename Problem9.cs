using System;
using System.Collections.Generic;
using System.Linq;

public class Problem9
{
    // public static void Main()
    // {
    //     Problem9 pb = new Problem9();
    //     Console.WriteLine(pb.IsPalindrome(141));
    // }

    public bool IsPalindrome(int x)
    {
        int number = x;
        if (x < 0) return false;
        List<int> list = new List<int>();
        int count=0;
        while (number != 0)
        {
            number /= 10;
            count++;
        }

        
        for ( ;count > 0; count--)
        {
            list.Add(x%10);
            x /= 10;
        }

        while (list.Count > 1)
        {
            if (list[0] != list[list.Count - 1]) return false;
            list.RemoveAt(0);
            list.RemoveAt(list.Count - 1);
        }

        return true;
    }
}