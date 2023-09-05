using System;
using System.Collections.Generic;
using System.Linq;

namespace IsSubsequence
{
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

            List<char> ind = new List<char>();
            for (int i = 0; i < sList.Length; i++)
            {
                for (int j = 0; j < tList.Length; j++)
                {
                    if (sList[i] == tList[j])
                    {
                        ind.Add(tList[j]);
                    }
                }
            }

            if (ind.Count != sList.Length)
            {
                return false;
            }

            // dizi ve listenin karşılaştırılması
            bool isSortedIndEqualOriginalInd = ind.SequenceEqual(sList);

            return isSortedIndEqualOriginalInd;
        }
    }
}
