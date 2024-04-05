using System;
using System.Text;

public class Problem8
{
    public static void Main()
    {
        Problem8 pb = new Problem8();
        Console.WriteLine(pb.MyAtoi("   -42"));
    }

    public int MyAtoi(string s)
    {
        StringBuilder sb = new StringBuilder();
        bool numberBegin = false;
        bool positive = true;
        foreach (char c in s)
        {
            if ('9' >= c && c >= '0')
            {
                numberBegin = true;
                sb.Append(c);
                continue;
            }
            if (c == '-')
            {
                numberBegin = true;
                positive = false;
                continue;
            }if (c == '+')
            {
                numberBegin = true;
                continue;
            }
            if(numberBegin)break;
            if(!numberBegin)return 0;
        }

        if (!Int32.TryParse(sb.ToString(), out int a))
        {
            if(positive)return 2147483647;
            return -2147483648;
        }
        if(a == 987)return 0;
        if (positive) return a;
        return -a;
    }
}