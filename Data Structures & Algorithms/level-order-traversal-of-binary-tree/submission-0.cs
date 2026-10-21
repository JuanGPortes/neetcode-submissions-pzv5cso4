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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> result = new List<List<int>>();

        Dfs(root, 0, result);

        return result;
    }

    private void Dfs(TreeNode node, int level, List<List<int>> result){
        if(node == null){
            return;
        }

        if(result.Count == level){
            result.Add(new List<int>());
        }

        result[level].Add(node.val);

        Dfs(node.left, level + 1, result);
        Dfs(node.right, level + 1, result);
    }
}
