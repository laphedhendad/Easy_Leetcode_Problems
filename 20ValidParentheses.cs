/*
 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
 */

using System;
using System.Collections.Generic;

namespace Valid_Parentheses
{
    class Program
    {
        static public bool IsValid(string s) {

            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (stack.Count > 0 && c == ')' && stack.Peek() == '(')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && c == '}' && stack.Peek() == '{')
                {
                    stack.Pop();
                }
                else if (stack.Count > 0 && c == ']' && stack.Peek() == '[')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }
            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("(([]){})"));
            Console.ReadLine();
        }
    }
}
