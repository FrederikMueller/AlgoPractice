namespace Algorithms.Medium;
public class ValidateBST
{
    /*
    	Problem Solving: I used a recursive approach to solve this problem. First I check the if the core properties of the BST are met for the current node, then I call the same function on the next node passing in a min and a max value to keep track of the "boundaries" for the nodes on that branch.
	    Issues: Mental basicness. Solution is pretty intuitive, but I completely forgot about the boundary (min,max) issue at first. When I looked at the graph version of a failed test, I immediately saw that the violation occurred because of that. Conceptually I didn’t think about that on my own beforehand. If you start out with this idea of every node having a min and max value, then this is much easier to solve.
	    Video Notes:
        O(N) T, O(d) S   d = depth, the highest number of call stacks is the depth of the tree
    */

    public bool ValidateBst(BST tree)
    {
        return tree.ValidateBSTHelper(Int32.MinValue, Int32.MaxValue);
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
        public bool ValidateBSTHelper(int min, int max)
        {
            if (value < min || value >= max)
                return false;

            if (left?.ValidateBSTHelper(min, value) == false)
                return false;
            if (right?.ValidateBSTHelper(value, max) == false)
                return false;

            return true;
        }
    }
}