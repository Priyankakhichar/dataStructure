using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("1.UnOrderedList");
                Console.WriteLine("2.OrderedList");
                Console.WriteLine("3.CheckParentheses");
                Console.WriteLine("4.Banking");
                Console.WriteLine("5.Palindrom");
                Console.WriteLine("6.HashingFunction");
                Console.WriteLine("7.BinarySearchTree");
                Console.WriteLine("8.Calander");
                Console.WriteLine("9.PrimeNumber");
                Console.WriteLine("10.Anagram");
                Console.WriteLine("11.StackAnagram");
                Console.WriteLine("12.AnagramUsingQueue");
                LinkedList list = new LinkedList();
                int choice;
                Console.WriteLine("please enter the choice");
                choice = Utility.ReadInt();
                switch(choice)
                {
                    case 1:
                            UnOrderedList list1 = new UnOrderedList();
                            Console.WriteLine("please enter the word , you want to search");
                            list.SearchString(Console.ReadLine());
                            list.WriteToFile();
                            list.Display();
                            break;
                    case 2: OrderedList list2 = new OrderedList();
                            Console.WriteLine("please enter a number ,you want to search");
                            list.SearchInteger(Utility.ReadInt());
                            break;
                    case 3: Console.WriteLine("please enter the string");
                            Utility.CheckParentheses(Console.ReadLine());
                            break;
                    case 4: CashCounterLogic b = new CashCounterLogic();
                            break;
                    case 5: PalindromeChecker p = new PalindromeChecker();
                            break;
                    case 6: HashingFunction hf = new HashingFunction();
                            break;
                    case 7: BinarySearchTree bt = new BinarySearchTree();
                            int count1, count2, n;
                            Console.WriteLine("please enter the number of nodes For you want to findout BinaryTree");
                            n = Utility.ReadInt();
                            count1 = bt.CountBST(n);
                            count2 = bt.CountBT(n);
                            Console.WriteLine("count of BST with " + n + " node is " + count1);
                            Console.WriteLine("count of Binary Tree with " + n + " node is " + count2);
                            break;
                    case 8: Calendar cl = new Calendar();
                            break;
                    case 9: PrimeNumbers pn = new PrimeNumbers();
                            pn.Display();
                            break;
                    case 10: Anagrams an = new Anagrams();
                             an.StoreInArray();
                             an.Anagram();
                             break;
                    case 11: StackAnagram sa = new StackAnagram();
                             sa.PrimeAnagarm();
                             sa.ReadingReverse();
                             break;
                    case 12: AnagramUsingQueue aq = new AnagramUsingQueue();
                             aq.PrimeAnagarm();
                             aq.ReadingData();
                             break;

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
