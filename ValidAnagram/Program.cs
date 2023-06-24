using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidAnagram
{
    //LeetCode Link:https://leetcode.com/problems/valid-anagram/

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsAnagram("anagram", "nagaram"));
        }

        public static bool IsAnagram(string s, string t)
        {
            List<char> sChar = new List<char> { };
            List<char> tChar = new List<char> { };
            for (int i = 0; i < s.Length; i++)
            {
                sChar.Add(s[i]);
            }
            for (int j = 0; j < t.Length; j++)
            {
                tChar.Add(t[j]);
            }
            sChar.Sort();
            tChar.Sort();
            return sChar.SequenceEqual(tChar);
        }
    }
}
