namespace BinaryTreeDay17
{
    public class BinarySearchTreeNode<K>
    {
        public K Key;                                                     
        public BinarySearchTreeNode<K> Right;                              
        public BinarySearchTreeNode<K> Left;                                

        public BinarySearchTreeNode(K Key)
        {
            this.Key = Key;
            Right = null;
            Left = null;
        }
    }
}