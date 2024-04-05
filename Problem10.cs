public class Problem10
{
    // public static void Main()
    // {
    //     Problem10 pb = new Problem10();
    //     Console.WriteLine(pb.IsMatch("abc", "a***abc"));
    // }

    public bool IsMatch(string s, string p)
    {
        p = p.Replace(".*", "0");
        string newStr = "";
        for (int i = 0; i < p.Length; i++)
        {
            if (i == p.Length - 1)
            {
                newStr += p[i];
                break;
            }

            if (p[i + 1] == '*')
            {
                if (p[i] == '*')
                {
                    newStr += '*';
                    continue;
                }
                newStr += char.ToUpper(p[i]);
                i++;
            }
            else
            {
                newStr += p[i];
            }
        }
        p = "";
        char temp = '-';
        foreach (char c in newStr)
        {
            if (char.IsLower(c) || temp != c || c == '.') p += c;
            temp = c;
        }
        return Match(s, p,0);
    }

    public bool Match(string s, string p, int layer)
    {
        if (layer > 20) return false;
        if (s.Length == 0 && p.Length == 0) return true;
        if (p.Length == 0) return false;
        if (char.IsUpper(p[0]))
        {
            if(s.Length>0)
            if (char.ToLower(p[0]) == s[0])
                if (Match(s.Substring(1), p, layer++))
                    return true;
            return Match(s, p.Substring(1), layer++);
        }

        if (s.Length > 0)
            if (s[0] == p[0] || p[0] == '.')
            {
                return Match(s.Substring(1), p.Substring(1), layer++);
            }

        if (p[0] == '0' || p[0] == '*')
        {
            if (Match(s, p.Substring(1), layer++)) return true;
            if(s.Length>0)
            return Match(s.Substring(1), p, layer++);
        }


        return false;
    }
}