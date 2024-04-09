using System;
using System.Collections.Generic;
using System.Text;

public class Problem68
{
    public static void Main()
    {
        Problem68 pb = new Problem68();
        Console.WriteLine(pb.FullJustify(new string[] { "What","must","be","acknowledgment","shall","be" },
            16));
    }

    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        int i = 0;
        int totalLength = 0;
        StringBuilder sb = new StringBuilder();
        List<string> justificated = new List<string>();
        List<string> tempList = new List<string>();
        while (i < words.Length)
        {
            if (words[i].Length + tempList.Count + totalLength <= maxWidth)
            {
                totalLength += words[i].Length;
                tempList.Add(words[i]);
                i++;
                continue;
            }

            int spaceLength = maxWidth - totalLength;
            int space;
            while (0 < tempList.Count)
            {
                sb.Append(tempList[0]);
                tempList.RemoveAt(0);
                space = (int)Math.Ceiling((double)spaceLength / (tempList.Count));
                spaceLength -= space;
                AppendMultipleTimes(sb, ' ', space);
            }
            AppendMultipleTimes(sb,' ' ,maxWidth-sb.ToString().Length);
            justificated.Add(sb.ToString());
            tempList.Clear();
            sb.Clear();
            totalLength = 0;
            //Console.WriteLine(tempList.Count);
        }

        while (0 < tempList.Count)
        {
            sb.Append(tempList[0]);
            tempList.RemoveAt(0);
            if ( tempList.Count != 0)
                sb.Append(' ');
        }
        AppendMultipleTimes(sb,' ' ,maxWidth-sb.ToString().Length);
        justificated.Add(sb.ToString());
        //Console.WriteLine(justificated.Count);
        return justificated;
    }

    static void AppendMultipleTimes(StringBuilder sb, char text, int times)
    {
        for (int i = 0; i < times; i++)
        {
            sb.Append(text);
        }
    }
}