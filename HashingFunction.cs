
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class HashingFunction
    {
        LinkedList[] list = new LinkedList[11];
        public HashingFunction()
        {
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\DataStructure\Test1.txt");
            //reading all numbers till to the end from stream
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] words = fileContent.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", words));
            int[] array = new int[words.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(words[i]);
            }
            //iterating loop for the list array
            for (int i = 0; i < array.Length; i++)
            {
                int rem = array[i] % 11;
                if(list[rem] == null)
                {
                    list[rem] = new LinkedList();
                    list[rem].AddInteger(array[i]);
                }
                else
                {
                    list[rem].AddInteger(array[i]);
                }
            }
            for(int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
                if(list[i] != null)
                {
                    list[i].Display();
                }
            }
            Console.WriteLine("please enter the number you want to search");
            int num = Utility.ReadInt();
            Search(num);
        }
        void Search(int n)
        {
            list[n % 11].SearchInteger(n);
            for (int i = 0; i < list.Length; i++)
            {
                list[i].WriteToFileInt();
            }
        }
    }
}
