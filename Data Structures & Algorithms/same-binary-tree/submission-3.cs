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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        // Both nodes are null
        if (p is null && q is null)
            return true;

        // One node is null and the other is not
        if (p is null || q is null)
            return false;

        // Values differ
        if (p.val != q.val)
            return false;

        // Compare left and right subtrees
        return IsSameTree(p.left, q.left) &&
            IsSameTree(p.right, q.right);
    }
}
