/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node == null)
        return null;

    Dictionary<Node, Node> map = new();

    Node Dfs(Node current)
    {
        if (map.ContainsKey(current))
            return map[current];

        Node clone = new Node();
        clone.val = current.val;
        clone.neighbors = new List<Node>();

        map[current] = clone;

        foreach (var neighbor in current.neighbors)
        {
            clone.neighbors.Add(Dfs(neighbor));
        }

        return clone;
    }

    return Dfs(node);
    }
}
