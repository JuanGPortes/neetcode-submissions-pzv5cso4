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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> result = new List<int>();
        if(root == null){
            return result;
        }

        Stack<TreeNode> stack = new();
        TreeNode current = root;

        while(current != null || stack.Count > 0){
            while(current != null){
                result.Add(current.val);

                if(current.right != null){
                    stack.Push(current.right);
                }

                current = current.left;
            }

            if(stack.Count > 0){
                current = stack.Pop();
            }
        }

        return result;
    }
}