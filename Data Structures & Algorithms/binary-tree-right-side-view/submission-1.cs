/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        DFS(root, 0, result);
        return result;
    }

    private void DFS(TreeNode node, int depth, IList<int> result)
    {
        if (node is null) 
            return;
        if (depth == result.Count)
            result.Add(node.val);
        DFS(node.right, depth + 1, result);
        DFS(node.left, depth + 1, result);
    }
    
}
