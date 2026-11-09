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
        List<int> result = new List<int>();

        Dfs(root, 0, result);

        return result;
    }

    private void Dfs(TreeNode node, int depth, List<int> result){
        if(node == null){
            return;
        }

        if(depth == result.Count){
            result.Add(node.val);
        }

        Dfs(node.right, depth + 1, result);
        Dfs(node.left, depth + 1, result);
    }
}
