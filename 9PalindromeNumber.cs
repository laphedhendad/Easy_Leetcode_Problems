/*
 * Given an integer x, return true if x is palindrome integer.
*/

using System;

namespace Palindrome_Number
{
    class Program
    {
        static public bool IsPalindrome(int x)
        {
            string x_str = x.ToString();
            int a = x_str.Length / 2;
            for (int i = 0; i < a; i++)
            {
                if (x_str[i] != x_str[x_str.Length - 1 - i]) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
        }
    }
}
