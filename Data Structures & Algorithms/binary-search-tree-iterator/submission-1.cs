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

    Stack<TreeNode> _stack;

    public BSTIterator(TreeNode root) {
        _stack = new Stack<TreeNode>();
        PushLeft(root);
    }

    private void PushLeft(TreeNode node){
        while(node != null){
            _stack.Push(node);
            node = node.left;
        }
    }
    
    public int Next() {
        TreeNode current = _stack.Pop();

        if(current.right != null){
            PushLeft(current.right);
        }

        return current.val;
    }
    
    public bool HasNext() {
        return _stack.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */