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
    public IList<string> BinaryTreePaths(TreeNode root) {

        if (root == null){
            return new List<string>();
        }

        var result = new List<string>();
        Dfs(root, "" , result);
        return result;
    }

    public void Dfs(TreeNode root, string current, List<string> result){

        if (root == null){
            return;
        }
        if (string.IsNullOrEmpty(current)){
            current = current + root.val.ToString();
        }
        else {
            current = current + "->" + root.val.ToString();
        }

        if (root.left == null && root.right == null){
            result.Add(current);
        }
        Dfs(root.right, current , result);
        Dfs(root.left, current , result);
    }

}
