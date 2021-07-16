/*
 * Write a function to find the longest common prefix string amongst an array of strings.
 */

using System;

namespace Longest_Common_Prefix
{
    class Solution
    {
        static public string LongestCommonPrefix(string[] strs)
        {
            string output = "";
            int min_len = 201;
            int min_id = 0;
            int i = 0;
            foreach (string s in strs)
            {
                if (s.Length < min_len)
                {
                    min_len = s.Length;
                    min_id = i;
                }
                i++;
            }
            i = 0;
            foreach (char c in strs[min_id])
            {
                foreach (string s in strs)
                {
                    if (c != s[i]) { return output; }
                }
                output += c.ToString();
                i++;
            }
            return output;
        }
        static void Main(string[] args)
        {
            string[] strs = new string[3] { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(strs));
        }
    }
}
