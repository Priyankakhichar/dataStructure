
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CashCounterLogic
    {
        static public Node first, last;
        public CashCounterLogic()
        {
            Console.WriteLine("please enter the number of customers in a queue");
            string[] name = new string[Utility.ReadInt()];
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("please enter the name of customer");
                name[i] = Console.ReadLine();
                Enqueue(name[i]);
            }
            int type;
            int amount;
            Console.WriteLine("please enter the total amount of Atm");
            int totalAmount = Utility.ReadInt();
            for (int i = 1; i <= name.Length; i++)
            {
                Console.WriteLine("please enter 1 if you want to deposite , enter 2 if you want to withdraw");
                type = Utility.ReadInt();
                if (type == 1)
                {
                    Console.WriteLine("please enter the amount you want to deposite");
                    amount = Utility.ReadInt();
                    if (amount > 0)
                    {
                        totalAmount = amount + totalAmount;
                        Console.WriteLine("total amount is " + totalAmount);
                        Dequeue(name[i]);
                    }
                    else
                    {
                        Console.WriteLine("not a valid amount");
                    }
                }
                else if (type == 2)
                {
                    Console.WriteLine("please enter the amount you want to withdraw");
                    amount = Utility.ReadInt();
                    if (totalAmount > (amount+1000) && amount < 20000 )
                    {
                        totalAmount = totalAmount - amount;
                        Console.WriteLine("total amount remaning is " + totalAmount);
                    }
                    else
                    {
                        Console.WriteLine("not a valid amount");
                    }
                }
                else
                {
                    Console.WriteLine("please enter the input between 1 and 2");
                }
            }

        }
        public static void Dequeue(string word)
        {
            Node current = first;
            if (first == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            //if data is at first node
            else if (first.data == word)
            {
                first = first.next;
            }
            else if (last.data == word)
            {
                //if data is at last node
                while (current.next != last)
                {
                    current = current.next;
                }
                last = current;
                current.next = null;
            }
            else
            {
                Node prev = first;
                while (current != null)
                {
                    if (current.data == word)
                    {
                        prev.next = current.next;
                        break;
                    }
                    prev = current;
                    current = current.next;
                }
            }
        }
        public static void Enqueue(string words)
        {
            Node node = new Node(words);
            node.data = words;
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

    }
}
