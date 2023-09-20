namespace SortColors
{
    //https://leetcode.com/problems/sort-colors/
    public class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            Console.WriteLine(SortColors(nums));
        }

        public static int[] SortColors(int[] nums)
        {
            int tutulanSayi = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        tutulanSayi = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tutulanSayi;
                    }
                }
            }
            return nums;
        }
    }
}
