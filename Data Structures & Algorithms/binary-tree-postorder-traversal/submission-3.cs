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
    public List<int> PostorderTraversal(TreeNode root) {
        var result = new List<int>();

        if(root == null){
            return result;
        }

        var stack = new Stack<TreeNode>();

        TreeNode curr = root;
        TreeNode lastVisited = null;

        while(curr != null || stack.Count > 0){
            if(curr != null){
                stack.Push(curr);
                curr = curr.left;
            }
            else{
                TreeNode peekNode = stack.Peek();

                if(peekNode.right != null && lastVisited != peekNode.right){
                    curr = peekNode.right;
                }
                else{
                    result.Add(peekNode.val);
                    lastVisited = stack.Pop();
                }
            }
        }

        return result;
    }
}