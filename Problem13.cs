using System;

public class Problem13
{
    // public static void Main()
    // {
    //     Problem13 pb = new Problem13();
    //     Console.WriteLine(pb.RomanToInt("MCMXCIV"));
    // }
    public int RomanToInt(string s)
    {
        int number = 0;
        bool Ipass=false;
        bool Xpass=false;
        bool Cpass=false;
        char si = ' ';
        for (int i = s.Length-1; i >=0; i--)
        {
            si = s[i];
            if (si == 'V' || si == 'X') Ipass = true;
            if (si == 'L' || si == 'C') Xpass = true;
            if (si == 'D' || si == 'M') Cpass = true;
            switch (si)
            {
                case 'I':
                    number += Ipass ? -1 : 1;
                    break;
                case 'V':
                    number += 5;
                    break;
                case 'X':
                    number += Xpass ? -10 : 10;
                    break;
                case 'L':
                    number += 50;
                    break;
                case 'C':
                    number += Cpass ? -100 : 100;
                    break;
                case 'D':
                    number += 500;
                    break;
                case 'M':
                    number += 1000;
                    break;
            }
        }

        return number;
    }
}