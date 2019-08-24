
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;
    class PalindromeChecker
    {
        public PalindromeChecker()
        {
            DequeUtility<char> utility = new DequeUtility<Char>();
            Console.WriteLine("Enter a String: ");
            String str = Console.ReadLine();

            //adding each character to the rear of the deque
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                utility.addRear(c);
            }
            int flag = 0;

            while (utility.Size() > 1)
            {
                if (utility.removeFront() != utility.removeRear())
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 0)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome");
            }
        }
    }
}