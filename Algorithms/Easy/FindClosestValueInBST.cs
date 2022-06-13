namespace Algorithms.Easy;
public class FindClosestValueInBST
{
    /*
     	Problem Solving: Simple enough if you map out the core functionality and comparisons.
	    Video Notes:
		Time = Avg: O(log(N)) Worst: O(N)
		Space = O(log(n))
    */
    private static int closestValue;
    public int FindClosestValue(BST tree, int target)
    {
        closestValue = tree.value;
        BSTDive(tree, target);

        return closestValue;
    }
    private void BSTDive(BST tree, int target)
    {
        if ((Math.Abs(target - tree.value)) < (Math.Abs(target - closestValue)))
            closestValue = tree.value;

        if (closestValue == target)
            return;

        if (tree.value < target && tree.right != null)
            BSTDive(tree.right, target);

        if (tree.value > target && tree.left != null)
            BSTDive(tree.left, target);
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
    }
}