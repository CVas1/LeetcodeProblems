using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Problem1544
{
    public static void Main()
    {
        Problem1544 pb = new Problem1544();
        Console.WriteLine(pb.MakeGood("abBAcC"));
    }

    public string MakeGood(string s)
    {
        int gap = 'a' - 'A';
        Stack<char> charStack = new Stack<char>();
        
        for (int i = 0; i < s.Length; i++)
        {
            if(charStack.Count()==0)
            {
                charStack.Push(s[i]);
            }
            else if (Math.Abs(charStack.Peek() - s[i]) == gap)
            {
                charStack.Pop();
            }
            else
            {
                charStack.Push(s[i]);
            }
        }
        
        StringBuilder stringBuilder = new StringBuilder();
        foreach (char c in charStack)
        {
            stringBuilder.Insert(0,c);
        }
        return stringBuilder.ToString();
    }
}