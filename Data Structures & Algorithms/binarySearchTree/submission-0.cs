class TreeMap {

    private class TreeNode{
        public int key;
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int key, int val, TreeNode left = null, TreeNode right = null){
            this.key = key;
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    TreeNode root;

    public TreeMap() {
        root = null;
    }

    public void Insert(int key, int val) {
        root = InsertIntoBST(root, key, val);
    }

    public int Get(int key) {
        return SearchBST(root, key);
    }

    public int GetMin() {
        return SearchMinBST(root);
    }

    public int GetMax() {
        return SearchMaxBST(root);
    }

    public void Remove(int key) {
        root = RemoveBST(root, key);
    }

    public List<int> GetInorderKeys() {
        List<int> keys = new List<int>();

        InorderTraversal(root, keys);

        return keys;
    }

    private TreeNode InsertIntoBST(TreeNode node, int key, int val){
        if(node == null){
            return new TreeNode(key, val);
        }

        if(key < node.key){
            node.left = InsertIntoBST(node.left, key, val);
        }
        else if(key > node.key){
            node.right = InsertIntoBST(node.right, key, val);
        }
        else{
            node.val = val;
        }

        return node;
    }

    private int SearchBST(TreeNode node, int key){
        if(node == null){
            return -1;
        }

        if(key < node.key){
            return SearchBST(node.left, key);
        }
        else if(key > node.key){
            return SearchBST(node.right, key);
        }
        else{
            return node.val;
        }
    }

    private int SearchMinBST(TreeNode node){
        TreeNode current = node;
        if(current == null){
            return -1;
        }

        while(current.left != null){
            current = current.left;
        }

        return current.val;
    }

    private int SearchMaxBST(TreeNode node){
        TreeNode current = node;

        if(current == null){
            return -1;
        }

        while(current.right != null){
            current = current.right;
        }

        return current.val;
    }

    private TreeNode RemoveBST(TreeNode node, int key){
        if(node == null){
            return node;
        }

        if(key < node.key){
            node.left = RemoveBST(node.left, key);
        }
        else if(key > node.key){
            node.right = RemoveBST(node.right, key);
        }
        else{
            if(node.left == null){
                return node.right;
            }
            else if(node.right == null){
                return node.left;
            }
            
            TreeNode minNode = GetMin(node.right);

            node.key = minNode.key;
            node.val = minNode.val;

            node.right = RemoveBST(node.right, minNode.key);
        }

        return node;
    }

    private TreeNode GetMin(TreeNode node){
        TreeNode current = node;
        while(current.left != null){
            current = current.left;
        }

        return current;
    }

    private void InorderTraversal(TreeNode node, List<int> keys){
        if(node == null){
            return;
        }

        InorderTraversal(node.left, keys);
        keys.Add(node.key);
        InorderTraversal(node.right, keys);
    }

}
