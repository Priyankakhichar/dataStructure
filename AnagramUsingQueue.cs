//-------------------------------------------------------------------------------------------------------------------------------
//<copyright file = "AnagramUsingQueue.cs" company ="Bridgelabz">
//Copyright © 2019 company ="Bridgelabz"
//</copyright>
//<creator name ="Priyanka khichar"/>
//
//------
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
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
            //condition for checking anagram
            for (int i = 0; i < k; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (newPrime[i] != 0)
                    {
                        string firstElement = newPrime[i].ToString();
                        string secondElement = newPrime[j].ToString();
                        if (firstElement.Length == secondElement.Length)
                        {
                            char[] charArray1 = firstElement.ToCharArray();
                            char[] charArray2 = secondElement.ToCharArray();
                            Array.Sort(charArray1);
                            Array.Sort(charArray2);
                            firstElement = new string(charArray1);
                            secondElement = new string(charArray2);
                            if (firstElement.Equals(secondElement))
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
