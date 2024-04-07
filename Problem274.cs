using System;

public class Problem274
{
    // public static void Main()
    // {
    //     Problem274 pb = new Problem274();
    //     Console.WriteLine(pb.HIndex(new []{3,0,6,1,5}));
    // }
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        int citiation = 0;
        for (int i = citations.Length-1; i >= 0; i--)
        {
            if (citations[i] >= citiation+1) citiation++;
            else break;
        }

        return citiation;
    }
}