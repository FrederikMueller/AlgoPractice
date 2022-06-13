namespace Algorithms.Easy;

public class Node
{
    /*
    	Problem Solving: Just foreach over the children and go directly into the next method call if a child has a child of its own.
	    Issues: It was fine, a bit rusty from not doing these algorith problems for a while, even though this one is superbly easy.
	    Video Notes: Nodes are called vertices in a graph. Lines between nodes are called edges.
		Time = O(V+E)
        Space =  O(V)
    */

    public string name;
    public List<Node> children = new List<Node>();

    public Node(string name)
    {
        this.name = name;
    }

    public List<string> DepthFirstSearch(List<string> array)
    {
        array.Add(this.name);
        foreach (var child in this.children)
        {
            child.DepthFirstSearch(array);
        }

        return array;
    }

    public Node AddChild(string name)
    {
        Node child = new Node(name);
        children.Add(child);
        return this;
    }
}