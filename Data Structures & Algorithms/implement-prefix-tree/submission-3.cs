public class PrefixTree {
    private readonly Node root;
    private class Node
    {
        public Node[] children = new Node[26];
        public bool isEnd;
    }
    

    public PrefixTree() 
    {
        root = new Node();
    }
    
    public void Insert(string word) {
        Node current = root;

        foreach (char c in word)
        {
            int index = c - 'a';
            if (current.children[index] == null)
                current.children[index] = new Node();

            current = current.children[index];
        }
        current.isEnd = true;
    }
    
    public bool Search(string word) {
        Node current = root;

        foreach (char c in word)
        {
            int index = c - 'a';
            if (current.children[index] == null)
                return false;

            current = current.children[index];
        }
        return current.isEnd;
    }
    
    public bool StartsWith(string prefix) {
        Node current = root;

        foreach (char c in prefix)
        {
            int index = c - 'a';
            if (current.children[index] == null)
                return false;

            current = current.children[index];
        }
        return true;
    }
}
