using System;

public class Problem135
{
    // public static void Main()
    // {
    //     Problem135 pb = new Problem135();
    //     Console.WriteLine(pb.Candy(new int[] { 1, 3, 4, 5, 2 }));
    // }

    public int Candy(int[] ratings)
    {
        int[] candies = new int[ratings.Length];

        for (int i = 1; i < ratings.Length; i++)
        {
            if (ratings[i] > ratings[i - 1])
            {
                candies[i] = candies[i - 1] + 1;
            }
        }

        for (int i = ratings.Length - 2; i >= 0; i--)
        {
            if (ratings[i] > ratings[i + 1])
            {
                candies[i] = candies[i + 1] + 1 > candies[i] ? candies[i + 1] + 1 : candies[i];
            }
        }


        int total = 0;
        foreach (int i in candies)
        {
            //Console.WriteLine(i);
            total += i;
        }

        return total + ratings.Length;
    }

    // public int Candy(int[] ratings)
    // {
    //     int[] candies = new int[ratings.Length];
    //     int total = 0;
    //     if (ratings.Length < 2) return ratings.Length;
    //     if (ratings[0] > ratings[1]) total += CandyCalculator(ratings, 0);
    //     for (int i = 1; i < ratings.Length; i++)
    //     {
    //         if (ratings[i] > ratings[i - 1]) candies[i] = candies[i - 1] + 1;
    //         else if (ratings[i] <= ratings[i - 1]) candies[i] = CandyCalculator(ratings, i);
    //         total += candies[i];
    //         // Console.WriteLine(total + "  i == " + i);
    //     }
    //
    //     foreach (int i in candies)
    //     {
    //         Console.WriteLine(i);
    //     }
    //
    //     return total + ratings.Length;
    //
    // }
    //
    // public int CandyCalculator(int[] ratings, int index)
    // {
    //     if (index == ratings.Length - 1) return 0;
    //     if (ratings[index] > ratings[index + 1]) return CandyCalculator(ratings, index + 1)+1;
    //     return 0;
    // }
}