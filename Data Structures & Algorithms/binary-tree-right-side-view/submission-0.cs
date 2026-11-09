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

        if(root == null){
            return result;
        }

        List<List<int>> allLevels = new List<List<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            int levelSize = queue.Count;
            List<int> currentLevel = new List<int>();

            for(int i = 0; i < levelSize; i++){
                TreeNode current = queue.Dequeue();
                currentLevel.Add(current.val);

                if(current.left != null) queue.Enqueue(current.left);
                if(current.right != null) queue.Enqueue(current.right);
            }
            
            allLevels.Add(currentLevel);
        }

        foreach(var level in allLevels){
            result.Add(level[level.Count - 1]);
        }

        return result;
    }
}
