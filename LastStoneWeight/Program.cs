using System;
using System.Collections.Generic;

namespace LastStoneWeight
{
    //https://leetcode.com/problems/last-stone-weight/

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] stones = { 2, 7, 4, 1, 8, 1 };
            Console.WriteLine(LastStoneWeight(stones));
        }

        public static int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 1) { return stones[0]; }

            var arrList = new List<int>(stones);
            arrList.Sort();

            for (int i = arrList.Count - 1; arrList.Count >= 0; i--)
            {
                int difference = arrList[i] - arrList[i - 1];
                arrList[i - 1] = difference;
                arrList.RemoveAt(i);
                arrList.Sort();

                if (arrList.Count == 1)
                {
                    return arrList[0];
                }
            }
            return 0;
        }
    }
}

