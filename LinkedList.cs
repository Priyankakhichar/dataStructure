
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class LinkedList
    {
         public Node first, last;
        public void AddString(string words)
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
        public void AddInteger(int data)
        {
            Node node = new Node(data);
            node.num = data;
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
        public int size()
        {
            Node current = first;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }
        public void SearchString(string word)
        {
            int position = 0;
            Node current = first;
            if (first == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (current != null)
            {
                if (current.data == word)
                {
                    Delete(word);
                    break;
                }
                current = current.next;
                position++;
            }
            if (current == null)
            {
                Console.WriteLine(word + " not found");
                AddString(word);
            }
            else
            {
                Console.WriteLine(word + " found at index " + position);
            }
        }
        public void SearchInteger(int num)
        {
            int position = 0;
            Node current = first;
            if (first == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (current != null)
            {
                if (current.num == num)
                {
                    DeleteInteger(num);
                    break;
                }
                current = current.next;
                position++;
            }
            if (current == null)
            {
                Console.WriteLine(num + " not found");
                AddInteger(num);
                Sort();
                Console.WriteLine("number added to the node");
            }
            else
            {
                Console.WriteLine(num + " found at index " + position);
            }
        }
        public void Display()
        {
            Node current = first;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
        public void Delete(string word)
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
        public void DeleteInteger(int num)
        {
            Node current = first;
            if (first == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            //if data is at first node
            else if (first.num == num)
            {
                first = first.next;
            }
            else if (last.num == num)
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
                //if data is at middle node
                Node prev = first;
                while (current != null)
                {
                    if (current.num == num)
                    {
                        prev.next = current.next;
                        break;
                    }
                    prev = current;
                    current = current.next;
                }
            }
        }
        public void WriteToFile()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\admin\source\repos\DataStructure\Test.txt");
            Node current = first;
            while (current != null)
            {
                writer.Write(current.data + " ");
                current = current.next;
            }
            writer.Close();
            Console.WriteLine("writing done");
        }
        public void WriteToFileInt()
        {
            StreamWriter writer = new StreamWriter(@"C:\Users\admin\source\repos\DataStructure\Test1.txt");
            Node current = first;
            while (current != null)
            {
                writer.Write(current.num + " ");
                current = current.next;
            }
            writer.Close();
            Console.WriteLine("writing done");
        }
        public void Sort()
        {
            for (int i = 0; i < size(); i++)
            {
                Node current = first;
                for (int j = 0; j < size() - 1 - i; j++)
                {
                    if (current.num > current.next.num)
                    {
                        var temp = current.num;
                        current.num = current.next.num;
                        current.next.num = temp;
                    }
                    current = current.next;
                }
            }
            Console.WriteLine("writing to the file");
            WriteToFileInt();
        }
    }
}
