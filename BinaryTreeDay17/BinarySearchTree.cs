namespace BinaryTreeDay17
{
    public class BinarySearchTreeNode<K>
    {
        public K Key;                                                        //values going to add
        public BinarySearchTreeNode<K> Right;                                //create variable for right side node
        public BinarySearchTreeNode<K> Left;                                 //creates varibale for left side node

        public BinarySearchTreeNode(K Key)
        {
            this.Key = Key;
            Right = null;
            Left = null;
        }
    }
}