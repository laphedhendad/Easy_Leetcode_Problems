/*
 * Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
 */

namespace ImplementStr
{
    class Solution
    {
        private int[] PrefixFunction(string s)
        {
            int[] pi = new int[s.Length];
            pi[0] = 0;

            for(int i = 1; i < s.Length; i++)
            {
                int k = pi[i - 1];

                while(k > 0 && s[i] != s[k])
                {
                    k = pi[k - 1];
                }

                if(s[i] == s[k])
                {
                    k++;
                }
                pi[i] = k;
            }
            return pi;
        }
        public int StrStr(string haystack, string needle)
        {
            int[] pi = PrefixFunction(needle + "#" + haystack);

            int n = needle.Length;

            for (int i = 0; i < haystack.Length; i++)
            {
                if (pi[n + i + 1] == n)
                {
                    return i - n + 1;
                }
            }

            return -1;
        }
    }
}
