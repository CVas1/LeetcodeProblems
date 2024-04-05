using System;

public class Problem11
{
    /*public static void Main()
    {
        Problem11 pb = new Problem11();
        Console.WriteLine(pb.MaxArea(new []{1115,764,6944,468,853}));
    }*/
    
    public int MaxArea(int[] height)
    {
        int maxVal = 0;
        int i = 0;
        int j = height.Length-1;
        int maxHeightJ = 0;
        int maxHeighti = 0;
        while (j >= i)
        {
            if (height[j] > height[i])
            {
                maxVal = maxVal < height[i] * (j - i) ? height[i] * (j - i) : maxVal;
                i++;
            }
            else
            {
                maxVal = maxVal < height[j] * (j - i) ? height[j] * (j - i) : maxVal;
                j--;
            }
        }

        return maxVal;
    }
}