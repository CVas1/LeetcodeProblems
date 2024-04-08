using System;
using System.Collections.Generic;

public class Problem134
{
    // public static void Main()
    // {
    //     Problem134 pb = new Problem134();
    //
    //     int[] gas = new int[] { 1, 2, 3, 4, 5 };
    //     int[] cost = new int[] { 3, 4, 5, 1, 2 };
    //     Console.WriteLine(pb.CanCompleteCircuit(gas, cost));
    // }

    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        int i = 0;
        int startIndex = 0;
        int gasLeft = 0;
        int turn = 0;
        while (i < gas.Length * 2)
        {
            gasLeft += gas[i% gas.Length] - cost[i% gas.Length];
            turn++;
            if (gasLeft < 0)
            {
                gasLeft = 0;
                turn = 0;
                startIndex = (i + 1) % gas.Length;
            }
            if (turn == gas.Length)
            {
                return startIndex;
            }
            
            i++;
        }

        return -1;
    }
}