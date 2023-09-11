using System;
using System.Collections.Generic;
using System.Linq;

namespace IsSubsequence
{
    //leetcode linki: https://leetcode.com/problems/is-subsequence/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSubsequence("acb", "ahbgdc"));
        }

        public static bool IsSubsequence(string s, string t)
        {
            char[] sList = s.ToCharArray();
            char[] tList = t.ToCharArray();

            int ind = -1;
            int count = 0;
            for (int i = 0; i < sList.Length; i++)
            {
                for (int j = ind + 1; j < tList.Length; j++)
                {
                    if (sList[i] == tList[j])
                    {
                        count++;
                        ind = j;
                        break;
                    }
                }
            }
            return count == sList.Length;
        }
    }
}
