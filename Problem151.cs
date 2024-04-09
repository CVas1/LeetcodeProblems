using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Problem151
{
    // public static void Main()
    // {
    //     Problem151 pb = new Problem151();
    //     Console.WriteLine(pb.ReverseWords("     hello    world    "));
    // }
    public string ReverseWords(string s)
    {
        List<string> words = s.Split(' ').ToList();
        words.RemoveAll(x => x == "");
        string str = "";
        for (int i = words.Count-1; i >= 0; i--)
        {
            str += words[i];
            if (i != 0) str += " ";
        }
        return str;
    }

}
    // public string ReverseWords(string s)
    // {
    //     Stack<string> stack = new Stack<string>();
    //     StringBuilder sb = new StringBuilder();
    //     for (int i = s.Length-1; i >=0; i--)
    //     {
    //         if (s[i] == ' ')
    //         {
    //             Console.WriteLine(stack.Count);
    //             stack.Push(sb.ToString());
    //             sb.Clear();
    //             continue;
    //         }
    //         sb.Append(s[i]);
    //     }
    //
    //     while (stack.Count > 0)
    //     {
    //
    //         sb.Append(' ');
    //         sb.Append(stack.Pop());
    //     }
    //
    //     return sb.ToString();
    // }




        // s += " ";
        // StringBuilder sb = new StringBuilder();
        // List<string> list = new List<string>();
        // foreach (char c in s)
        // {
        //     if (c != ' ')
        //     {
        //         sb.Append(c);
        //         sb.Clear();
        //     }
        //     else
        //     {
        //         list.Add(sb.ToString());
        //         sb.Clear();
        //     }
        // }
        // list.ForEach(s1 =>
        // {
        //     sb.Append(s1);
        //     sb.Append(' ');
        // });
        // sb.Remove(sb.Length - 1, 1);
        // return sb.ToString();
