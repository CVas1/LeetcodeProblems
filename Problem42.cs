
    using System;
    using System.Linq;

    public class Problem42
    {
        // public static void Main()
        // {
        //     Problem42 pb = new Problem42();
        //     int[] height = new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 };
        //     Console.WriteLine(pb.Trap(height));
        // }
        
        public int Trap(int[] height)
        {
            int max = height.Max();
            int index = Array.IndexOf(height,max);
            int indexLast = Array.LastIndexOf(height,max);
            int total = 0;
            int temp = 0;
            for (int i = 0; i < index; i++)
            {
                if (height[i] < temp) total += temp - height[i];
                else temp = height[i];
            }
            
            for (int i = index+1; i < indexLast; i++)
            {
                total += max - height[i];
            }

            temp = 0;
            for (int i = height.Length-1; i > indexLast; i--)
            {
                if (height[i] < temp) total += temp - height[i];
                else temp = height[i];
            }

            return total;
        }
        
    }
