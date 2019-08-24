
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Anagrams
    {
        int[,] primeNumber = new int[10, 1000];
        int[] array = new int[500];
        bool prime;
        int k = 0;
        public Anagrams()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j < (i + 1) * 100; j++)
                {
                    if (IsPrime(j))
                    {
                        primeNumber[i, j] = j;
                    }
                }
            }
        }
        public bool IsPrime(int num)
        {
            for (int i = 2; i < num / 2; i++)
            {
                prime = true;
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }

        public void StoreInArray()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = (i * 100) + 1; j < (i + 1) * 100; j++)
                {
                    if (primeNumber[i, j] != 0)
                    {
                        int temp = primeNumber[i, j];
                        array[k] = temp;
                        k++;
                    }
                }
            }
        }
        public void Anagram()
        {
            for(int i = 0; i < k; i++)
            {
                for(int j = i+1; j < k; j++)
                {
                    string str1 = array[i].ToString();
                    string str2 = array[j].ToString();
                    if (str1.Length == str2.Length)
                    {
                        char[] char1 = str1.ToCharArray();
                        char[] char2 = str2.ToCharArray();
                        Array.Sort(char1);
                        Array.Sort(char2);
                        str1 = new string(char1);
                        str2 = new string(char2);
                        if(str1 == str2)
                        {
                            Console.WriteLine(array[i] + "--> "+array[j]);
                        }
                    }
                }
            }
        }
    }
}
