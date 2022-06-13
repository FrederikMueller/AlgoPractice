namespace Algorithms.Medium;
public class BSTTraversal
{
    /*
    	Problem Solving: Easy shit
	    Video Notes:
		Pre Order Traversal: CURRENT LEFT RIGHT
		In order traversal: LEFT CURRENT RIGHT
        Post Order Traversal: LEFT RIGHT CURRENT
    */
    public List<int> InOrderTraverse(BST tree, List<int> array)
    {
        return tree.InOrderTraverse(array);
    }

    public List<int> PreOrderTraverse(BST tree, List<int> array)
    {
        return tree.PreOrderTraverse(array);
    }

    public List<int> PostOrderTraverse(BST tree, List<int> array)
    {
        return tree.PostOrderTraverse(array);
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }
        public List<int> PreOrderTraverse(List<int> array)
        {
            array.Add(value);

            left?.PreOrderTraverse(array);
            right?.PreOrderTraverse(array);
            return array;
        }
        public List<int> InOrderTraverse(List<int> array)
        {
            left?.InOrderTraverse(array);

            array.Add(value);

            right?.InOrderTraverse(array);
            return array;
        }
        public List<int> PostOrderTraverse(List<int> array)
        {
            left?.PostOrderTraverse(array);
            right?.PostOrderTraverse(array);

            array.Add(value);
            return array;
        }
    }
}