namespace Algorithms.Medium;

public class BST
{
    /*
        Problem Solving:
        Issues: Removal of nodes is difficult. First of all think more clearly about in what order to tackle a certain algorithmic problem, find the most efficient one, trennschärfe maxen. Secondly, sorting out the edge cases was kind of annoying I have to say. I did consult the video before solving this. Wasn't  the best performance.
        Video Notes:
        With each node you can eliminate roughly half of the remaining tree.
    */
    public int value;
    public BST left;
    public BST right;

    public BST(int value)
    {
        this.value = value;
    }

    public BST Insert(int value)
    {
        if (value < this.value)
        {
            if (left == null)
                left = new BST(value);
            else
                left.Insert(value);
        }
        else
        {
            if (right == null)
                right = new BST(value);
            else
                right.Insert(value);
        }

        return this;
    }

    public bool Contains(int value)
    {
        if (this.value == value)
            return true;

        if (value < this.value)
        {
            if (left == null)
                return false;
            else
                return left.Contains(value);
        }
        else
        {
            if (right == null)
                return false;
            else
                return right.Contains(value);
        }
    }

    public BST Remove(int value)
    {
        Remove(value, null);
        return this;
    }

    public void Remove(int value, BST parent)
    {
        if (value < this.value)
        {
            if (left != null)
                left.Remove(value, this);
        }
        else if (value > this.value)
        {
            if (right != null)
                right.Remove(value, this);
        }
        else // the node's value equals the value we want to remove
        {
            if (left != null && right != null)
            {
                this.value = right.FindSmallest();
                right.Remove(this.value, this);
            }
            else if (parent == null) // ROOT
            {
                if (left != null)
                {
                    this.value = left.value;
                    right = left.right;
                    left = left.left;
                }
                else if (right != null)
                {
                    this.value = right.value;
                    left = right.left;
                    right = right.right;
                }
                else
                {
                    // Do nothing
                }
            }
            else if (parent.left == this)
            {
                parent.left = left != null ? left : right;
            }
            else if (parent.right == this)
            {
                parent.right = left != null ? left : right;
            }
        }
    }

    public int FindSmallest()
    {
        if (left == null)
            return this.value;
        else
            return left.FindSmallest();
    }
}