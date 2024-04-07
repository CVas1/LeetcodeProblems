using System;

public class Problem88
{
    // public static void Main()
    // {
    //     Problem88 pb = new Problem88();
    //     int[] nums1 = { 1, 2, 3, 0, 0, 0 };
    //     int[] nums2 = { 2, 5, 6 };
    //     int m = 3;
    //     int n = 3;
    //     pb.Merge(nums1,m,nums2,n);
    // }
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        Array.Copy(nums2,0,nums1,m,n);
        Array.Sort(nums1);
    }
}