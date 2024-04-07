using System;
using System.Collections.Generic;
using System.Linq;

public class Problem17
{
    // public static void Main()
    // {
    //     Problem17 pb = new Problem17();
    //     Console.WriteLine(pb.LetterCombinations("2794"));
    // }

    public IList<string> LetterCombinations(string digits)
    {
        Dictionary<char, char[]> dict = new Dictionary<char, char[]>()
        {
            { '2', new char[] { 'a', 'b', 'c' } },
            { '3', new char[] { 'd', 'e', 'f' } },
            { '4', new char[] { 'g', 'h', 'i' } },
            { '5', new char[] { 'j', 'k', 'l' } },
            { '6', new char[] { 'm', 'n', 'o' } },
            { '7', new char[] { 'p', 'q', 'r', 's' } },
            { '8', new char[] { 't', 'u', 'v' } },
            { '9', new char[] { 'w', 'x', 'y', 'z' } }
        };
        List<string> list = new List<string>();
        if (digits.Length == 0) return list;
        foreach (char c in dict[digits[0]])
        {
            list.Add(c.ToString());
        }
        if (digits.Length == 1) return list;
        foreach (char digit in digits.Substring(1))
        {
            //Console.WriteLine(digit);
            List<string> tempList = new List<string>(list);
            list.Clear();
            foreach (char c in dict[digit])
            {
                
                foreach (string str in tempList)
                {
                    
                    list.Add(str + c);
                }
            }
        }

        //list.ForEach(c => Console.WriteLine(c));
        return list;
    }
}