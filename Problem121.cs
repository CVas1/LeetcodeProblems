using System;

public class Problem121
{
    // public static void Main()
    // {
    //     Problem121 pb = new Problem121();
    //     Console.WriteLine(pb.MaxProfit(new[] { 3, 2, 6, 5, 0, 3 }));
    // }

    public int MaxProfit(int[] prices)
    {
        int min = prices[0];
        int profit = 0;
        int temp;

        for (int i = 0; i < prices.Length; i++)
        {
            temp = prices[i];
            if (temp < min) min = temp;
            profit = profit > temp - min ? profit : temp - min;
        }
        
        return profit;
    }
}