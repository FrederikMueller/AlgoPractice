namespace Algorithms.Easy;
public class NodeDepths
{
    public int GetNodeDepth(BinaryTree root)
    {
        return DepthFirstSearch(root, 0);
    }
    public int DepthFirstSearch(BinaryTree tree, int depth)
    {
        int currentSum = depth;

        if (tree.left != null)
            currentSum += DepthFirstSearch(tree.left, depth + 1);
        if (tree.right != null)
            currentSum += DepthFirstSearch(tree.right, depth + 1);

        return currentSum;
    }
}