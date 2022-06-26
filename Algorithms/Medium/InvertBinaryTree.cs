namespace Algorithms.Medium;
public class InvertBinaryTree
{
    /*
    Fully understand the problem
        Invert a binary tree by swapping every left node in the tree for its corresponding right node.
    Look for potential simplifications of the problem
        One swap on each node's children will automatically lead to a fully inverted tree.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Start at the root, swap left and right. Call the same swapping method on both children. Return immediately if the argument was null (tree == null).
    Then implement the simplified conceptual solution step by step
        Straightforward solution.
    Optimization. Big O analysis. Amortization?
        Time = n
        Space = 1
    Video Notes:
        For the iterative solution you can use a queue to enqueue nodes you will be operating on next.
    */
    public void Invert(BinaryTree tree)
    {
        if (tree == null)
            return;

        BinaryTree temp = tree.left;
        tree.left = tree.right;
        tree.right = temp;

        Invert(tree.left);
        Invert(tree.right);
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }
}