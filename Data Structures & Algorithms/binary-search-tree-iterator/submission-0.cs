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
public class BSTIterator {

    Queue<TreeNode> _queue;

    public BSTIterator(TreeNode root) {
        _queue = new Queue<TreeNode>();
        InorderTraversal(root);
    }

    private void InorderTraversal(TreeNode node){
        if(node == null){
            return;
        }

        InorderTraversal(node.left);
        _queue.Enqueue(node);
        InorderTraversal(node.right);
    }
    
    public int Next() {
        return _queue.Dequeue().val;
    }
    
    public bool HasNext() {
        return _queue.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */