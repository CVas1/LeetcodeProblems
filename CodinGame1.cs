using System;
using System.Collections.Generic;
using System.Linq;

class Player
{
    public static void Main(string[] args)
    {
        List<int> mountains = new List<int>();
        // game loop
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                int mountainH = int.Parse(Console.ReadLine()); // represents the height of one mountain.
                mountains.Add(mountainH);
            }

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            int index = mountains.IndexOf(mountains.Max(x => x));
            Console.WriteLine(); // The index of the mountain to fire on.
            mountains.RemoveAt(index);
        }
    }
}