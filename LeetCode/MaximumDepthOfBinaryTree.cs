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
public class Solution
{
    private int GetHeight(TreeNode root)
    {
        if (root == null)
        {
            return -1;
        }
        return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
    }
    public int MaxDepth(TreeNode root)
    {
        return GetHeight(root) + 1;
    }
}
