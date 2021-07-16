/*
 * Given a signed 32-bit integer x, return x with its digits reversed. 
 * If reversing x causes the value to go outside the signed 32-bit integer range, then return 0.
 */

using System;

namespace Reverse_Integer
{
    class Solution
    {
        static public int Reverse(int x)
        {
            long rev = 0;
            while (x != 0)
            {
                int pop = x % 10;
                x /= 10;
                rev = rev * 10 + pop;
            }
            int ans;
            try
            {
                ans = checked((int)rev);
            }
            catch
            {
                return 0;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(123));
        }
    }
}
