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
    public IList<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();
        Helper(root, result);
        return result;
    }
    public void Helper(TreeNode root, List<int> result){
        if (root == null) {
            return;
        }
        Helper(root.left , result);
        Helper(root.right, result);
        result.Add(root.val);
    }
}
