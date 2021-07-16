using System;
using System.Collections.Generic;
using System.Text;

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
