namespace Algorithms.VeryHard;

public class AllKindsOfNodeDepths
{
    public int GetSumOfAllNodeDepths(BinaryTree root)
    {
        int sum = DFS2(root, 0);

        return sum / 2;
    }

    public int DFS1(BinaryTree tree, int depth)
    {
        int currentSum = depth;

        if (tree.left != null)
            currentSum += DFS1(tree.left, depth + 1);
        if (tree.right != null)
            currentSum += DFS1(tree.right, depth + 1);

        return currentSum;
    }
    public int DFS2(BinaryTree tree, int depth)
    {
        int currentSum = DFS1(tree, depth);

        if (tree.left != null)
            currentSum += DFS2(tree.left, depth + 1);
        if (tree.right != null)
            currentSum += DFS2(tree.right, depth + 1);

        return currentSum;
    }

    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}