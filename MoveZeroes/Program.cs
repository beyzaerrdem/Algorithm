using System;

namespace MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 1, 0, 3, 12 };
            Console.WriteLine(MoveZeroes(num));
        }

        public static int[] MoveZeroes(int[] nums)
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
            return nums;
        }
    }
}
