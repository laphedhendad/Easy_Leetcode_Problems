/*
 * Given a non-empty array of decimal digits representing a non-negative integer, increment one to the integer.
 */

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {

            digits[digits.Length - 1] += 1;

            for (int i = digits.Length - 1; i > 0; i--)
            {
                if (digits[i] == 10)
                {
                    digits[i] = 0;
                    digits[i - 1] += 1;
                }
            }
            if (digits[0] == 10)
            {
                int[] output = new int[digits.Length + 1];
                output[0] = 1;
                return output;
            }

            return digits;
        }
    }
}
