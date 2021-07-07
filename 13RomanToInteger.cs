/*
 * Given a roman numeral, convert it to an integer.
 */

using System;
using System.Collections.Generic;

namespace RomanToInt
{
    class Program
    {
        static Dictionary<string, int> dict = new Dictionary<string, int>{
        {"I", 1},
        {"V", 5},
        {"X", 10},
        {"L", 50},
        {"C", 100},
        {"D", 500},
        {"M", 1000},
        {"IV", 4},
        {"IX", 9},
        {"XL", 40},
        {"XC", 90},
        {"CD", 400},
        {"CM", 900}
        };
        static Stack<char> stack = new Stack<char>();
        static public int RomanToInt(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            s = new string(charArray);
            foreach (char c in s)
            {
                stack.Push(c);
            }
            char c1;
            char c2;
            string temp;
            int result = 0;
            while (stack.Count > 1) {
                c1 = stack.Pop();
                c2 = stack.Pop();
                temp = c1.ToString() + c2.ToString();
                if (dict.ContainsKey(temp))
                {
                    result += dict[temp];
                }
                else
                {
                    stack.Push(c2);
                    result += dict[c1.ToString()];
                }
            }
            if (stack.Count == 0) return result;
            result += dict[stack.Pop().ToString()];
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("IV"));
            Console.ReadLine();
        }
    }
}
