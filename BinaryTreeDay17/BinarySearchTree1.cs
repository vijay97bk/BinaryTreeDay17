using System;

namespace BinaryTreeDay17
{
        public class BinarySearchTree<K> where K : IComparable
        {
            public BinarySearchTreeNode<K> Root;
        /// <summary>
        /// UC1
        /// </summary>
        /// <param name="Key"></param>
            public void AddNode(K Key)
            {
                Root = AddRecursively(Root, Key);
            }
            private BinarySearchTreeNode<K> AddRecursively(BinarySearchTreeNode<K> Current, K Key)
            {
                if (Current == null)
                    return new BinarySearchTreeNode<K>(Key);

                int CompareResult = Key.CompareTo(Current.Key);

                if (CompareResult == 0)
                    return Current;

                if (CompareResult < 0)
                    Current.Left = AddRecursively(Current.Left, Key);

                else
                    Current.Right = AddRecursively(Current.Right, Key);
                return Current;
            }
        /// <summary>
        /// UC2
        /// </summary>
        /// <returns></returns>
        public int GetSizeOfTree()
        {
            return this.GetSizeRecursively(Root);
        }
        private int GetSizeRecursively(BinarySearchTreeNode<K> Current)
        {
           
            return Current == null ? 0 : 1 + this.GetSizeRecursively(Current.Left)
                                           + this.GetSizeRecursively(Current.Right);
        }
        public bool SearchKey(K key)
        {
            return SearchRecursively(Root, key);
        }

        private bool SearchRecursively(BinarySearchTreeNode<K> Current, K key)
        {
            if (Current == null)
                return false;
            if (Current.Key.CompareTo(key) == 0)
                return true;
            else
                return SearchRecursively(Current.Left, key) || SearchRecursively(Current.Right, key);
        }
    }
}