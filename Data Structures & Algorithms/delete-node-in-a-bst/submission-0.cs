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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null){
            return null;
        }

        List<int> values = new List<int>();
        InOrderTraversal(root, values);

        values.Remove(key);

        if(values.Count == 0){
            return null;
        }

        TreeNode newRoot = new TreeNode(values[0]);
        for(int i = 1; i < values.Count; i++){
            InsertIntoBST(newRoot, values[i]);
        }

        return newRoot;
    }

    private void InOrderTraversal(TreeNode root, List<int> values){
        if(root == null){
            return;
        }

        InOrderTraversal(root.left, values);
        values.Add(root.val);
        InOrderTraversal(root.right, values);
    }

    private TreeNode InsertIntoBST(TreeNode root, int val){
        if(root == null){
            return new TreeNode(val);
        }

        if(val < root.val){
            root.left = InsertIntoBST(root.left, val);
        }
        else if(val > root.val){
            root.right = InsertIntoBST(root.right, val);
        }

        return root;
    }
}