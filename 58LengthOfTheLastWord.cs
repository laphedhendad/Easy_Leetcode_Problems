/*
 * Given a string s consists of some words separated by spaces, return the length of the last word in the string.
 * If the last word does not exist, return 0.
 */

namespace LengthOfLastWord
{
    class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int n = 0;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    if (n == 0) continue;
                    else return n;
                }
                else n++;
            }
            return n;
        }
    }
}
