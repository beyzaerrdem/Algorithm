using System;

namespace MoveZeroes
{
    //https://leetcode.com/problems/move-zeroes/

    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] num = { 0, 1, 0, 3, 12 };
            MoveZeroes(num);
            Console.WriteLine(string.Join(", ", num));
        }

        public static void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {              
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }
                    nums[nums.Length - 1] = 0;
                }
            }
        }
    }
}
