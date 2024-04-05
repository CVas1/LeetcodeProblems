using System;

public class Problem7
{
    // public static void Main()
    // {
    //     Problem7 pb = new Problem7();
    //     Console.WriteLine(pb.Reverse(-2147483648));
    // }
    public int Reverse(int x)
    {
        if (x == -2147483648) return 0;
        string s = ""+Math.Abs(x);
        char[] arr = s.ToCharArray();
        int n = s.Length;
        char tempChar;
        for (int i = 0; i < (n / 2); i++)
        {
            tempChar = arr[i];
            arr[i] = arr[n - i-1];
            arr[n - i-1] = tempChar;
        }

        s = "";
        foreach (char c in arr)
        {
            s += c;
        }

        if(!Int32.TryParse(s, out n))return 0;
        if (x < 0) return -n;
        return n;
    }
}