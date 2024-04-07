using System;

public class Problem122
{
    // public static void Main()
    // {
    //     Problem122 pb = new Problem122();
    //     Console.WriteLine(pb.MaxProfit(new[] { 3, 2, 6, 5, 0, 3 }));
    // }

    public int MaxProfit(int[] prices)
    {
        int min = Int32.MaxValue;
        int max = 0;

        int profit = 0;
        
        int priceI;
        
        for (int i = 0; i < prices.Length; i++)
        {
            priceI = prices[i];
            if (max > priceI)
            {
                profit += max - min;
                max = 0;
                min = Int32.MaxValue;
            }
            if (min > priceI)
            {
                min = priceI;
            }
            if (max < priceI)
            {
                max = priceI;
            }
        }

        if (min < max) profit += max - min;

        return profit;
    }
}