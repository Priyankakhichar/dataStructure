
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class PrimeNumbers
    {
        int[,] primeNumber = new int[10,1000];
        bool prime;
        public PrimeNumbers()
        {
            for(int i =0; i < 10; i++)
            {
                for(int j = (i*100) + 1; j <= (i+1)*100; j++)
                {
                    if(IsPrime(j))
                    {
                        primeNumber[i, j] = j;
                    }
                }
            }
        }
        public bool IsPrime(int num)
        {
            for(int i = 2; i < num / 2; i++)
            {
                prime = true;
                if(num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
        public void Display()
        {
            for(int i = 0;i <10; i++)
            {
              for(int j = (i * 100) + 1; j <= (i + 1) * 100; j++)
                {
                    if (primeNumber[i, j] != 0)
                    {
                        Console.Write(primeNumber[i, j] + " , ");
                    }
                }
                Console.WriteLine();
            }
        }
       
    }
}
