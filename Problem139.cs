using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Problem139
{
    // public static void Main()
    // {
    //     Problem139 pb = new Problem139();
    //     List<string> list = new List<string>() { "leet","code"};
    //     Console.WriteLine(pb.WordBreak("leetcode",list));
    // }
    
    public bool WordBreak(string s, IList<string> wordDict)
    {
        int n = s.Length;
        bool[] arr = new bool[n + 1];
        int maxLength=0;
        foreach (string str in wordDict)
        {
            maxLength = Math.Max(str.Length, maxLength);
        }

        arr[0] = true;
        
        for (int i = 0; i < n; i++)
        {
            if (arr[i])
            {
                foreach (string str in wordDict)
                {
                    if(s.Substring(i, Math.Min(str.Length,n-i)).Contains(str)) arr[i + str.Length] = true;
                }
            }
        }

        return arr[s.Length];

    }
}
