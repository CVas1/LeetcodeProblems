using System;
using System.Text;

//Thor Game
public class CodinGame2
{
    public void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position
        
        StringBuilder sb = new StringBuilder();
        
        // game loop
        while (true)
        {
            sb.Clear();
            int remainingTurns =
                int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.

            if (initialTy < lightY) { sb.Append("S"); initialTy++; }
            else if (initialTy > lightY) { sb.Append("N"); initialTy--; }
            if (initialTx < lightX) { sb.Append("E"); initialTx++; }
            else if (initialTx > lightX) { sb.Append("W"); initialTx--; }


            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(sb.ToString());
        }
    }
}