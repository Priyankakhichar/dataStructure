
namespace DataStructure
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class BinarySearchTree
    {    //formula to calculate BST is = (2n)! / ((n+1)! * n!)
        //formula to calculate BT is = Bst(n) * n!  ; where n is no of nodes
        //calculate the factorial of a number
        public int Factorial(int num)
        {
            int fact = 1;
            for(int i = num; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }
        //function to count no of BST
        public int CountBST(int n)
        {
            return Factorial(2 * n) / (Factorial(n + 1) * Factorial(n));
        }
        //function to count Binary tree with n nodes
        public int CountBT(int n)
        {
            return CountBST(n) * Factorial(n);
        }
    }
}
