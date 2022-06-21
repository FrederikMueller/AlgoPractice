namespace Algorithms.Medium;
public class MinHeightBST
{
    /*
    Fully understand the problem
        Input: non empty sorted array of distinct ints. Out: return root of bst
        Minimize the height of the BST. Construct the bst and use the insert method given in the prompt if you want.
    Look for potential simplifications of the problem
        Minimizing the height means you have to make sure you halve the array each time.
    Lay out an abstract path from input to output. Think about what types of solutions might work.
        Pick the root via midpoint of input array. Everything lower goes into the left side of the tree and vice versa.
        Then pick the midpoint each subarray and make those the children of root. Repeat this until you're done.
    Then implement the simplified conceptual solution step by step
        1 2 5 8  10  12 14 15 18
        Recursively construct the BST, check for each case (leaf node, 1 child (left or right), 2 children)
            => all covered by the return null on lower > upper
        Did work first try in the end, but I was stuck initially because I got baited by the given insert method (now deleted).
        Feels clean and simple though.
    Optimization. Big O analysis. Amortization?
        Time = N
        Space = N
    Video Notes:
        If the prompt was different and the input array could have duplicates, then this exact solution wouldn’t work.
    */
    public BST MinHeightBst(List<int> array)
    {
        return ConstructNodeFromBounds(0, array.Count - 1, array);
    }
    BST ConstructNodeFromBounds(int lower, int upper, List<int> array)
    {
        if (lower > upper)
            return null;

        int nodeIdx = (lower + upper) / 2;
        var node = new BST(array[nodeIdx]);

        node.left = ConstructNodeFromBounds(lower, nodeIdx - 1, array);
        node.right = ConstructNodeFromBounds(nodeIdx + 1, upper, array);

        return node;
    }

    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
            left = null;
            right = null;
        }
    }
}