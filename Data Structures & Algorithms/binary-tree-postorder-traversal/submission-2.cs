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

        var stack = new Stack<(TreeNode Node, bool Visited)>();
        stack.Push((root, false));

        while(stack.Count > 0){
            var current = stack.Pop();

            if(current.Visited){
                result.Add(current.Node.val);
            }
            else{
                stack.Push((current.Node, true));

                if(current.Node.right != null) stack.Push((current.Node.right, false));
                if(current.Node.left != null) stack.Push((current.Node.left, false));
            }
        }

        return result;
    }
}