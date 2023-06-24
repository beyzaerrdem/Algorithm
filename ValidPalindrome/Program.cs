using System;
using System.Text.RegularExpressions;

namespace ValidPalindrome
{
    //https://leetcode.com/problems/valid-palindrome/solutions/
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
        }

        public static bool IsPalindrome(string s)
        {
            string pattern = @"[\d\p{P}]";
            s = Regex.Replace(s, pattern, " ");
            string s1 = s.Replace(" ", "");

            string reverseS = "";

            for (int i = s1.Length - 1; i >= 0; i--)
            {
                reverseS += s1[i];
            }
            if (reverseS.ToLower() == s1.ToLower())
            {
                return true;
            }
            return false;
        }
    }
}

