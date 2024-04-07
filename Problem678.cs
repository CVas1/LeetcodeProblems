using System;
using System.Collections.Generic;

public class Problem678
{
    // public static void Main()
    // {
    //     Problem678 pb = new Problem678();
    //     Console.WriteLine(pb.CheckValidString("((((()(()()()*()(((((*)()*(**(())))))(())()())(((())())())))))))(((((())*)))()))(()((*()*(*)))(*)()"));
    // }

    public bool CheckValidString(string s)
    {
        int left = 0;
        int right = 0;
        int starLeft = 0;
        int starRight = 0;
        int i = 0;
        char tempChar = '-';
        
        while (left + starLeft >= 0 && i<s.Length)
        {
            tempChar = s[i];
            if (tempChar == '(') left++;
            else if (tempChar == '*') starLeft++;
            else 
            {
                if (left > 0) left--;
                else if (starLeft > 0) starLeft--;
                else return false;
            }

            i++;
        }
        i--;
        while (right + starRight >= 0 && i>=0)
        {
            tempChar = s[i];
            if (tempChar == ')') right++;
            else if (tempChar == '*') starRight++;
            else
            {
                if (right > 0) right--;
                else if (starRight > 0) starRight--;
                else return false;
            }

            i--;
        }
        return true;
    }
}
