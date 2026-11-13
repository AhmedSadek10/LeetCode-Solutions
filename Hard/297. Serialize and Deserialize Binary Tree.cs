/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Codec
{
    // Encodes a tree to a single string.
    public string serialize(TreeNode root)
    {
        var values = new List<string>();

        SerializeDfs(root, values);

        return string.Join(",", values);
    }

    private void SerializeDfs(TreeNode node, List<string> values)
    {
        if (node == null)
        {
            values.Add("N");
            return;
        }

        values.Add(node.val.ToString());

        SerializeDfs(node.left, values);
        SerializeDfs(node.right, values);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data)
    {
        var values = data.Split(',');
        int index = 0;

        return DeserializeDfs(values, ref index);
    }

    private TreeNode DeserializeDfs(string[] values, ref int index)
    {
        if (values[index] == "N")
        {
            index++;
            return null;
        }

        var node = new TreeNode(int.Parse(values[index]));
        index++;

        node.left = DeserializeDfs(values, ref index);
        node.right = DeserializeDfs(values, ref index);

        return node;
    }
}
