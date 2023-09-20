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
            //int[] dizi = { -1, 10, 6, 7, -7, 1 };
            int[] dizi = { 8, 1, 2, 2, 3 };
            Console.WriteLine(SmallerNumbersThanCurrent(dizi));
        }

        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            List<int> l = new List<int>();
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {          
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        count++;
                    }
                }
                l.Add(count);
                count = 0;
            }
            return l.ToArray();
        }

        //    public static int FindMaxK(int[] nums)
        //    {
        //        Array.Sort(nums);
        //        for (int i = 0; i < nums.Length; i++)
        //        {
        //            if (nums[i] < 0)
        //            {
        //                if (nums.Contains(-(nums[i])))
        //                {
        //                    return -nums[i];
        //                }
        //            }
        //        }
        //        return -1;
        //    }
        //}

    }
    }

