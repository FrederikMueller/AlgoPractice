namespace Algorithms.Easy;

public class BranchSums
{
    /*
		    Time = O(N)
            Space = O(N) (roughly half of all nodes are leaf nodes aka end nodes)
    */
    public List<int> GetBranchSum(BinaryTree root)
    {
        var listOfBranchSums = new List<int>();
        SumBranch(root, 0, listOfBranchSums);
        return listOfBranchSums;
    }

    public void SumBranch(BinaryTree tree, int currentSum, List<int> branchSums)
    {
        currentSum += tree.value;

        if (tree.left == null && tree.right == null)
            branchSums.Add(currentSum);

        if (tree.left != null)
            SumBranch(tree.left, currentSum, branchSums);
        if (tree.right != null)
            SumBranch(tree.right, currentSum, branchSums);
    }
}

public class BinaryTree
{
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value)
    {
        this.value = value;
        this.left = null;
        this.right = null;
    }
}