using System;
using System.Collections.Generic;
using System.Linq;

namespace IsSubsequence
{
    //https://leetcode.com/problems/largest-positive-integer-that-exists-with-its-negative/

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { -1, 10, 6, 7, -7, 1 };
            Console.WriteLine(FindMaxK(dizi));
        }

        public static int FindMaxK(int[] nums)
        {
            Array.Sort(nums);
            int deger = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    deger = nums[i] - (nums[i] * 2);
                    if (nums.Contains(deger))
                    {
                        return deger;
                    }
                }
            }
            return -1;
        }
    }
}

