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
    public int KthSmallest(TreeNode root, int k) {
        List<int> values = new List<int>();
        InorderTraversal(root, values);

        return values[k - 1];
    }

    private void InorderTraversal(TreeNode node, List<int> values){
        if(node == null){
            return;
        }

        InorderTraversal(node.left, values);
        values.Add(node.val);
        InorderTraversal(node.right, values);
    }
}
