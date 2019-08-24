
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class DequeUtility<E>
    {
        public DequeUtility()
        {
        }

        Deque<E> front;
        Deque<E> rear;
        int size = 0;

        //add front
        public void addFront(E c)
        {
            if (front == null) //if no element in list
            {
                Deque<E> node = new Deque<E>(c);
                front = node;
                rear = front;
            }
            else  //if element in list
            {
                Deque<E> node = new Deque<E>();
                node.data = c;
                node.next = front;
                front.pre = node;
                front = node;
            }
            size++;
        }

        //add rear
        public void addRear(E c)
        {
            if (front == null) //if no element in list
            {
                Deque<E> node = new Deque<E>(c);
                front = node;
                rear = front;
            }
            else  //if element in list
            {
                Deque<E> node = new Deque<E>(c);
                rear.next = node;
                node.pre = rear;
                rear = node;
            }
            size++;
        }

        //remove front
        public E removeFront()
        {
            E val = default(E);
            if (front == null)
            {
                Console.WriteLine("No elements to delete");
            }
            else
            {
                val = front.data;
                front = front.next;
            }
            size--;
            return val;
        }

        //remove rear
        public E removeRear()
        {
            E val = default(E);
            if (front == null)
            {
                Console.WriteLine("No element to delete");
            }
            else
            {
                val = rear.data;
                rear = rear.pre;
                rear.next = null;
            }
            size--;
            return val;
        }

        //to remove
        public bool isEmpty()
        {
            if (front == null)
                return true;
            else
                return false;
        }

        //return size of deque
        public int Size()
        {
            return size;
        }
    }
}
