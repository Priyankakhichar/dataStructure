
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Node
    {
        public string data;
        public int num;
        public Node next,prev;
        protected int data1;
        protected Node link;
        public Node()
        {
            link = null;
            data1 = 0;
        }
        public Node(int d, Node n)
        {
            data1 = d;
            link = n;
        }
        //function to set data to node
        public void SetData(int d)
        {
            data1 = d;
        }
        //function to get link to next node
        public Node GetLink()
        {
            return link;
        }
        //function to set link to next node
        public void SetLink(Node n)
        {
            link = n;
        }
        //function to get data from current node
        public int GetData()
        {
            return data1;
        }
        public Node(String data)
        {
            this.data = data;
        }
        public Node(int num)
        {
            this.num = num;
        }
    }
}
