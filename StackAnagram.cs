
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class StackAnagram
    {
        int[] prime = new int[1000];
        int[] newPrime = new int[500];
        int k = 0;
        LStack stack = new LStack();
       public void PrimeAnagarm()
        {
            for(int i = 10; i<= 1000; i++)
            {
                if(IsPrime(i))
                {
                    prime[i] = i;
                }
            }
            for(int i = 0; i < prime.Length; i++ )
            {
                if(prime[i] != 0)
                {
                    newPrime[k++] = prime[i];
                }
            }
            //condition for checking anagram
            for(int i = 0; i < k; i++)
            {
                for(int j = i+1; j < k; j++)
                {
                    if(newPrime[i] != 0)
                    { 
                      string str1 = newPrime[i].ToString();
                      string str2 = newPrime[j].ToString();
                        if (str1.Length == str2.Length)
                        {
                            char[] c1 = str1.ToCharArray();
                            char[] c2 = str2.ToCharArray();
                            Array.Sort(c1);
                            Array.Sort(c2);
                            str1 = new string(c1);
                            str2 = new string(c2);
                            if (str1.Equals(str2))
                            {
                                stack.Push(newPrime[i]);
                            }
                        }
                    }
                }
            }
        }
        //reading data in Reverse Order
        public void ReadingReverse()
        {
            stack.Display();
        }
        //method to check Prime number
        public bool IsPrime(int num)
        {
            bool isPrime = true;
            for(int i = 2; i <= num/2; i++)
            {
                if(num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
    class LStack
    {
        Node first, last;
        //adding the data in stack
        public void Push(int data)
        {
            Node node = new Node();
            node.num = data;
            Console.WriteLine(node.num);
            if (first == null)
            {
                first = node;
            }
            else
            {
                last = first;
                while (last.next != null)
                {
                    last = last.next;
                }
                last.next = node;
                node.prev = last;
                last = node;
            }
        }
        //displaying the data in reverse order
        public void Display()
        {
            Node current = last;
            while (current != null)
            {
                Console.Write(current.num.ToString() + " ");
                current = current.prev;
            }
        }
    }
}
