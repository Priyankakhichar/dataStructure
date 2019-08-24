
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;
    using System.IO;
    class OrderedList
    {
        public OrderedList()
        {
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\DataStructure\Test1.txt");
            //reading all numbers till to the end from stream
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] words = fileContent.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", words));
            int[] array = new int[words.Length];
            for(int i=0; i< array.Length; i++)
            {
                array[i] = Convert.ToInt32(words[i]);
            }
            LinkedList list = new LinkedList();
            for (int i = 0; i < words.Length; i++)
            {
                list.AddInteger(array[i]);
            }
            list.Sort();
        }
    }
}
