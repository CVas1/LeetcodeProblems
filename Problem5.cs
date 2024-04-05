using System;

public class Problem5
{
    // public static void Main()
    // {
    //     Problem5 p3 = new Problem5();
    //     Console.WriteLine(p3.LongestPalindrome("aaaa"));
    // }

    public string LongestPalindrome(string s)
    {
        char[] charArr = s.ToCharArray();
        int min = 0;
        int max = 0;
        for (int i = 0; i < s.Length-1; i++)
        {
            int tempMin = 0;
            int tempMax = 0;
            if (charArr[i] == charArr[i + 1])
            {
               tempMin = i;
               tempMax = i + 1;
                //string tempStr = charArr[i] + "" + charArr[i + 1];
                for (int j = 1; i - j >= 0 && j + i < s.Length; j++)
                {
                    if(i+1 + j >= s.Length) break;
                    if (charArr[i - j] == charArr[i+1 + j])
                    {
                        tempMin = i - j;
                        tempMax = i + j+1;
                        //tempStr = charArr[i - j] + tempStr + charArr[i + j];
                    }
                    else
                    {
                        break;
                    }
                }

                if (tempMax-tempMin  > max-min )
                {
                    Console.WriteLine(tempMin + " " + tempMax);
                    min = tempMin;
                    max = tempMax;
                }
                // if (tempStr.Length > max.Length)
                // {
                //     max = tempStr;
                // }
            }

            if(i == 0) continue;
            if (charArr[i - 1] == charArr[i + 1])
            {
                tempMin = i - 1;
                tempMax = i + 1;
                //string tempStr = charArr[i - 1] + "" + charArr[i] + "" + charArr[i + 1];
                for (int j = 2; i - j >= 0 && j + i < s.Length; j++)
                {
                    if (charArr[i - j] == charArr[i + j])
                    {
                        tempMin = i - j;
                        tempMax = i + j;
                        //tempStr = charArr[i - j] + tempStr + charArr[i + j];
                    }
                    else
                    {
                        break;
                    }
                }
                if (tempMax-tempMin  > max-min )
                {
                    Console.WriteLine(tempMin + " === " + tempMax);
                    min = tempMin;
                    max = tempMax;
                }
                // if (tempStr.Length > max.Length)
                // {
                //     max = tempStr;
                // }
            }
        }
        //if(s.Length == max.Length) return s;
        if (max-min == 0) return s[0].ToString();
        //if(max == "" && s.Length > 0) return s[0].ToString();
        return s.Substring(min, max - min + 1);
    }
    
}