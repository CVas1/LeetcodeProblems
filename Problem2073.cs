
    using System;

    public class Problem2073
    {
        // public static void Main()
        // {
        //     Problem2073 pb = new Problem2073();
        //     Console.WriteLine(pb.TimeRequiredToBuy(new int[] { 2, 3, 4, 5, 6 }, 3));
        // }
        public int TimeRequiredToBuy(int[] tickets, int k)
        {
            int total = 0;
            int max = tickets[k];
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] < max) total += tickets[i];
                else if (i <= k) total += max;
                else total += max - 1;
            }

            return total;
        }
    }
