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
        if(root == null){
            root = new TreeNode(key, val);
            return;
        }

        TreeNode current = root;
        while(true){
            if(key < current.key){
                if(current.left == null){
                    current.left = new TreeNode(key, val);
                    return;
                }
                current = current.left;
            }
            else if(key > current.key){
                if(current.right == null){
                    current.right = new TreeNode(key, val);
                    return;
                }
                current = current.right;
            }
            else{
                current.val = val;
                return;
            }
        }
    }

    public int Get(int key) {
        TreeNode current = root;
        while(current != null){
            if(key < current.key){
                current = current.left;
            }
            else if(key > current.key){
                current = current.right;
            }
            else{
                return current.val;
            }
        }

        return -1;
    }

    public int GetMin() {
        if(root == null){
            return -1;
        }

        TreeNode current = root;
        while(current.left != null){
            current = current.left;
        }

        return current.val;
    }

    public int GetMax() {
        if(root == null){
            return -1;
        }

        TreeNode current = root;
        while(current.right != null){
            current = current.right;
        }

        return current.val;
    }

    public void Remove(int key) {
        root = RemoveHelper(root, key);
    }

    private TreeNode RemoveHelper(TreeNode node, int key){
        if(node == null){
            return null;
        }

        if(key < node.key){
            node.left = RemoveHelper(node.left, key);
        }
        else if(key > node.key){
            node.right = RemoveHelper(node.right, key);
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

            node.right = RemoveHelper(node.right, minNode.key);
        }

        return node;
    }

    private TreeNode GetMin(TreeNode node){
        while(node.left != null){
            node = node.left;
        }

        return node;
    }

    public List<int> GetInorderKeys() {
        List<int> keys = new List<int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();

        TreeNode current = root;

        while(current != null | stack.Count > 0){
            while(current != null){
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            keys.Add(current.key);

            current = current.right;
        }

        return keys;
    }

}
