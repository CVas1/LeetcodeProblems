using System;
using System.Text;

public class Problem28
{
    // public static void Main()
    // {
    //     Problem28 pb = new Problem28(); 
    //     
    //     Console.WriteLine(pb.StrStr("leetcode", "leeto"));
    // }
    
    public int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length-needle.Length; i++)
        {
            if(haystack.Substring(i, needle.Length) == needle)return i;
        }
        return -1;
    }
    
}