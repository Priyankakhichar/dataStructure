using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class AnagramUsingQueue
    {
        int[] prime = new int[1000];
        int[] newPrime = new int[500];
        int k = 0;
        LQueue queue = new LQueue();
        public void PrimeAnagarm()
        {
            for (int i = 10; i <= 1000; i++)
            {
                if (IsPrime(i))
                {
                    prime[i] = i;
                }
            }
            for (int i = 0; i < prime.Length; i++)
            {
                if (prime[i] != 0)
                {
                    newPrime[k++] = prime[i];
                }
            }
            Console.WriteLine(string.Join(" ", newPrime));
            //condition for checking anagram
            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (newPrime[i] != 0)
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
                                queue.Enqueue(newPrime[i]);
                            }
                        }
                    }
                }
            }
        }
        //reading data in Reverse Order
        public void ReadingData()
        {
            queue.Display();
        }
        //method to check Prime number
        public bool IsPrime(int num)
        {
            bool isPrime = true;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

    }
    class LQueue
    {
        Node head, tail;
        public void Enqueue(int data)
        {
            Node node = new Node();
            node.num = data;
            if(head == null)
            {
                head = node;
            }
            else
            {
                tail = head;
                while(tail.next != null)
                {
                    tail = tail.next;
                }
                tail.next = node;
                tail = node;
            }
        }
        public void Dequeue(int data)
        {
            if(head == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else if(head.num == data)
            {
                head = head.next;
            }
        }
        public void Display()
        {
            Node current = head;
            if (current == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                while (current.next != null)
                {
                    Console.WriteLine(current.num);
                    current = current.next;
                }
            }
        }
    }
}
