/*
* Given a non-negative integer x, compute and return the square root of x.
* Since the return type is an integer, the decimal digits are truncated, and only the integer part of the result is returned.
*/
using System;
namespace Easy_Leetcode_Problems
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            float eps = 0.01f, S = x, a = 1, b = x;
            while (Math.Abs(a - b) > eps)
            {
                a = (a + b) / 2;
                b = S / a;
            }
            if ((int)((a + b) / 2) * (int)((a + b) / 2) > x) return (int)((a + b - 1) / 2);
            return (int)((a + b) / 2);
        }
    }
}
