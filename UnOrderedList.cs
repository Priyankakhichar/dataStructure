
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    class UnOrderedList
    {
        public UnOrderedList()
        {
            StreamReader sr = new StreamReader(@"C:\Users\admin\source\repos\DataStructure\Test.txt");
            //reading all charcters till to the end from stream
            string fileContent = sr.ReadToEnd();
            sr.Close();
            string[] words = fileContent.Split(new char[] {' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ", words));
            LinkedList list = new LinkedList();
            for(int i = 0; i < words.Length; i++)
            {
                list.AddString(words[i]);
            }
        }
       
    }
}
