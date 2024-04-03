using System;

public class Problem4
{
    // public static void Main()
    // {
    //     Problem4 p3 = new Problem4();
    //     Console.WriteLine(p3.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 }));
    // }

    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int i = 0;
        int j = 0;
        int arrLength = nums1.Length + nums2.Length;
        int[] arr = new int[arrLength];
        bool nums1Finished;
        bool nums2Finished;
        while (true)
        {
            nums1Finished = i >= nums1.Length;
            nums2Finished = j >= nums2.Length;
            if (nums1Finished && nums2Finished) break;
            if (nums1Finished && !nums2Finished)
            {
                arr[i + j] = nums2[j];
                j++;
                continue;
            }

            if (!nums1Finished && nums2Finished)
            {
                arr[i + j] = nums1[i];
                i++;
                continue;
            }

            if (nums1[i] < nums2[j])
            {
                arr[i + j] = nums1[i];
                i++;
            }
            else
            {
                arr[i + j] = nums2[j];
                j++;
            }
        }

        if (arrLength % 2 == 0) return (arr[arrLength / 2] + (double)arr[arrLength / 2 - 1]) / 2;
        return arr[arrLength / 2];
    }
}