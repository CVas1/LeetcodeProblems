using System;

public class Problem6
{
    // public static void Main()
    // {
    //     Problem6 pb = new Problem6();
    //     Console.WriteLine(pb.Convert("PAYPALISHIRING",3));
    // }
    public string Convert(string s, int numRows)
    {
        if (numRows == 1) return s;
        string[] arrayStr = new string[numRows];
        int currentRow = 0;
        bool increase = true;
        for (int i = 0; i < s.Length; i++)
        {
            arrayStr[currentRow] += s[i];
            
            if (currentRow == 0) increase = true;
            else if (currentRow == numRows - 1) increase = false;
            
            if (increase) currentRow++;
            else currentRow--;
        }

        string result = "";
        foreach (string str in arrayStr)
        {
            result += str;
        }

        return result;
    }
}