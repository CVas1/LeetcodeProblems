using System;

public class Problem420
{
    // public static void Main()
    // {
    //     Problem420 pb = new Problem420();
    //     Console.WriteLine(pb.StrongPasswordChecker("FFFFFFFFFFFFFFF11111111111111111111AAA"));
    // }

    public const int ExMark = 21;
    public const int Dot = 46;
    public const int DigitMin = 48;
    public const int DigitMax = 57;
    public const int LetterMinUpper = 65;
    public const int LetterMaxUpper = 90;
    public const int LetterMinLower = 97;
    public const int LetterMaxLower = 122;

    public int Upper;
    public int Lower;
    public int Digit;
    public int[] Repetitions;

    public int StrongPasswordChecker(string password)
    {
        Repetitions = new int[password.Length + 1];
        if (password.Length <= 3) return 6 - password.Length;
        char temp = password[0];
        int repeat = 0;
        foreach (char c in password)
        {
            if (c >= LetterMinLower && c <= LetterMaxLower) Lower = 1;
            if (c >= LetterMinUpper && c <= LetterMaxUpper) Upper = 1;
            if (c >= DigitMin && c <= DigitMax) Digit = 1;
            if (c == temp)
            {
                repeat++;
            }
            else
            {
                Repetitions[repeat] += 1;
                repeat = 1;
            }

            temp = c;
        }

        if (password[password.Length - 1] == temp) Repetitions[repeat] += 1;

        foreach (var i in Repetitions)
        {
            Console.Write(i + " ");
        }

      
        if (password.Length < 6)
        {
            if (Lower + Upper + Digit == 0) return 3;
            if (password.Length == 4) return 2;
            if (Lower + Upper + Digit == 1) return 2;
            return 1;
        }

        
        
        int tempInt = 0;
        int temp0=0;
        int temp1=0;
        int temp2=0;
        
        
        int deleteCount = password.Length - 20;
        if (deleteCount < 0) deleteCount = 0;
        int tempDeleteCount = deleteCount;
        
        for (int i = 3; i < Repetitions.Length; i++)
        {
            tempInt += (i / 3) * Repetitions[i];
            if (i % 3 == 0) temp0+= (i / 3) * Repetitions[i];
            else if (i % 3 == 1) temp1+= (i / 3) * Repetitions[i];
            else temp2+= (i / 3) * Repetitions[i];
        }
        Console.WriteLine("temp0 " + temp0);
        Console.WriteLine("temp1 " + temp1);
        Console.WriteLine("temp2 " + temp2);

        while (true)
        {
            if (temp0 > 0 && tempDeleteCount > 0 && tempInt>=1)
            {
                temp0--;
                tempDeleteCount--;
                tempInt--;
                continue;
            }

            if (temp1>0 && tempDeleteCount>1&& tempInt>=1)
            {
                temp1--;
                tempDeleteCount -= 2;
                tempInt--;
                continue;
            }

            if (temp2>0 && tempDeleteCount>2&& tempInt>=1)
            {
                temp2--;
                tempDeleteCount -= 3;
                tempInt--;
                continue;
            }



            break;
        }
        Console.WriteLine("deletecount " + deleteCount);
        Console.WriteLine("tempint " + tempInt);
        Console.WriteLine("Lowerdigitupper " + (3-Lower-Upper-Digit));
        if (tempInt <= 3 - (Lower + Upper + Digit)) return 3 - (Lower + Upper + Digit)+deleteCount;
        if (tempInt > 3 - (Lower + Upper + Digit) && deleteCount ==0) return tempInt;
        if (tempInt > 3 - (Lower + Upper + Digit) ) return tempInt+deleteCount;
        return deleteCount+ tempInt + 3 - (Lower + Upper + Digit);

    }
}
//        FFbFFbFFFbFFbFF11111111111111111111AA
// 1 4