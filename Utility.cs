
namespace DataStructure
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.IO;
    class Utility
    {
        public static int ReadInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
       
        public static void CheckParentheses(string str)
        {
            Stack stack = new Stack();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '{' || str[i] == '[' || str[i] == '(' || str[i] == '<')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == '}' || str[i] == ']'||str[i]==')'||str[i] =='>')
                {
                    if(str[i] == '}' && stack.Peek().ToString() =="{" ||
                        str[i] == ']' && stack.Peek().ToString() == "[" ||
                        str[i] == ')' && stack.Peek().ToString() == "(" ||
                            str[i] == '>' && stack.Peek().ToString() == "<" )
                    {
                        stack.Pop();
                    }
                }
            }
            if(stack.Count == 0)
            {
                Console.WriteLine(" Balanced Parentheses ");
            }
            else
            {
                Console.WriteLine(" Parentheses not Balanced ");
            }
        }
    }
}
