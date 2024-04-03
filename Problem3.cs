using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Problem3
{
    // public static void Main()
    // {
    //     Problem3 p3 = new Problem3();
    //     Console.WriteLine(p3.LengthOfLongestSubstring("auef"));
    // }

    public int LengthOfLongestSubstring(string s)
    {
        char[] charArr = s.ToCharArray();
        if (charArr.Length < 2) return charArr.Length;

        int max = 0;
        for (int i = 0; i < s.Length; i++)
        {
            List<char> charList = new List<char>();
            int tempMax = 0;
            for (int j = i; j < s.Length; j++)
            {
                if (charList.Contains(charArr[j]))
                    break;
                charList.Add(charArr[j]);
                tempMax++;
                if (tempMax > max) max = tempMax;
            }
        }
        return max;
    }


    // public int LengthOfLongestSubstring(string s)
    // {
    //     if (s.Length == 0) return 0;
    //     char[] charArr = s.ToCharArray();
    //     HashSet<char> set = new HashSet<char>(s);
    //     Dictionary<char, string> dict = new Dictionary<char, string>();
    //     foreach (var ch in set)
    //     {
    //         string tempStr = ch + "";
    //         string max = "";
    //         for (int i = 0; i < charArr.Length; i++)
    //         {
    //             if (ch == charArr[i])
    //             {
    //                 tempStr = ch + "";
    //             }
    //             else
    //             {
    //                 tempStr += charArr[i];
    //             }
    //
    //             if (tempStr.Length > max.Length)
    //             {
    //                 max = tempStr;
    //             }
    //
    //             if (dict.ContainsKey(ch))
    //                 dict[ch] = max;
    //             else dict.Add(ch, max);
    //         }
    //     }
    //
    //     int maxCount = 1;
    //     foreach (KeyValuePair<char, string> kv in dict)
    //     {
    //         string tempStr = kv.Value;
    //         foreach (char c in tempStr)
    //         {
    //             int last = s.IndexOf(c);
    //
    //
    //             for (int i = s.IndexOf(c); i > -1; i = s.IndexOf(c, i + 1))
    //             {
    //                 Console.WriteLine(i + " " + c);
    //                 if (i - last > maxCount)
    //                 {
    //                     maxCount = i - last;
    //                 }
    //
    //                 last = i;
    //             }
    //         }
    //     }
    //
    //
    //     foreach (var keyValuePair in dict)
    //     {
    //         Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
    //     }
    //
    //     return maxCount;
    // }


    // Time Limit Exceeded

    // }public int LengthOfLongestSubstring(string s) {
    //     
    //     List<char> charArr = s.ToCharArray().ToList();
    //     int max=0;
    //     while(charArr.Count > 0)
    //     {
    //         List<char> tempArr = new List<char>();
    //         
    //         int tempCount=0;
    //         
    //         for (int i = 0; i < charArr.Count; i++)
    //         {
    //             if(tempArr.Contains(charArr[i]))
    //             {
    //                 tempArr.Clear();
    //                 tempCount = 0;
    //                 
    //             }
    //             else
    //             {
    //                 tempArr.Add(charArr[i]);
    //                 tempCount++;
    //             }
    //             if(tempCount > max)max = tempCount;
    //         }
    //         
    //         charArr.RemoveAt(0);
    //         
    //     }
    //     return max;
    // }
}