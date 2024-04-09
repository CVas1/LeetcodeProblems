using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Problem71
{
    // public static void Main()
    // {
    //     Problem71 pb = new Problem71();
    //     Console.WriteLine(pb.SimplifyPath("/a/./b/../../c/"));
    // }

    public string SimplifyPath(string path)
    {
        List<string> paths = path.Split('/')
            .Where(s => !string.IsNullOrWhiteSpace(s) && s != ".")
            .ToList();
        for (int i = 0; i < paths.Count; i++)
        {
            if (paths[i] == "..")
            {
                paths.RemoveAt(i--);
                if (i >= 0) paths.RemoveAt(i--);
            }
        }

        StringBuilder sb = new StringBuilder();
        paths.ForEach(x =>
        {
            if (!string.IsNullOrEmpty(x)) sb.Append("/" + x);
        });
        if (string.IsNullOrEmpty(sb.ToString())) return "/";
        return sb.ToString();
    }
}