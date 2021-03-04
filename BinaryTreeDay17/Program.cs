using System;

namespace BinaryTreeDay17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Binary Tree search");
            BinarySearchTree<int> BinaryTree = new BinarySearchTree<int>();
            ///<summary>
            ///UC1
            /// </summary>
            BinaryTree.AddNode(10);
            BinaryTree.AddNode(20);
            BinaryTree.AddNode(30);
            BinaryTree.AddNode(15);
            BinaryTree.AddNode(05);
            BinaryTree.AddNode(40);
            BinaryTree.AddNode(35);
            //UC2 Size of tree
            int Size = BinaryTree.GetSizeOfTree();
            Console.WriteLine(Size);
            //UC3 search
            bool result = BinaryTree.SearchKey(15);
            Console.WriteLine(result);

        }

    }
}
