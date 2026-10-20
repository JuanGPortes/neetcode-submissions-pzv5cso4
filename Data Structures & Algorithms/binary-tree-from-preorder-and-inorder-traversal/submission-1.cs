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

    private Dictionary<int, int> inorderMap;
    private int preorderIdx;

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        preorderIdx = 0;
        inorderMap = new Dictionary<int, int>();

        for(int i = 0; i < inorder.Length; i++){
            inorderMap[inorder[i]] = i;
        }

        return Build(preorder, 0, inorder.Length -1);
    }

    private TreeNode Build(int[] preorder, int left, int right){
        if(left > right){
            return null;
        }

        int rootVal = preorder[preorderIdx++];
        TreeNode root = new TreeNode(rootVal);

        int mid = inorderMap[rootVal];

        root.left = Build(preorder, left, mid - 1);
        root.right = Build(preorder, mid + 1, right);

        return root;
    }
}
