using System;

public class Problem58
{
    // public static void Main()
    // {
    //     Problem58 pb = new Problem58();
    //     Console.WriteLine(pb.LengthOfLastWord("   fly me   to   the moon  "));
    // }
    
    public int LengthOfLastWord(string s)
    {
        int n = s.Length;
        int count = 0;
        for (int i = n-1; i>=0; i--)
        {
            if(count == 0 && s[i] == ' ') continue;
            else if(s[i] == ' ') return count;
            count++;
        }

        return count;
    }
}