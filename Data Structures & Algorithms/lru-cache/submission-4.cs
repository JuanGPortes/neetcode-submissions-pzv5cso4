public class LRUCache {

    private class Node{
        public int Key;
        public int Value;
        public Node Prev;
        public Node Next;

        public Node(int key, int value){
            Key = key;
            Value = value;
        }
    }

    private readonly int capacity;
    private readonly Dictionary<int, Node> cache;
    private readonly Node left;
    private readonly Node right;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, Node>();
        left = new Node(0, 0);
        right = new Node(0, 0);
        left.Next = right;
        right.Prev = left;
    }

    private void Remove(Node node){
        Node prev = node.Prev;
        Node next = node.Next;

        prev.Next = next;
        next.Prev = prev;
    }

    private void Insert(Node node){
        Node prev = right.Prev;
        Node next = right;

        prev.Next = node;
        next.Prev = node;

        node.Prev = prev;
        node.Next = next;
    }
    
    public int Get(int key) {
        if(cache.TryGetValue(key, out Node node)){
            Remove(node);
            Insert(node);
            return node.Value;
        }
        else{
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)){
            Node node = cache[key];
            Remove(node);
            Insert(node);

            node.Value = value;
            return;
        }
        else{
            if(cache.Count >= capacity){
                Node node = left.Next;
                Remove(node);
                cache.Remove(node.Key);
            }
        }

        Node newNode = new Node(key, value);
        cache[key] = newNode;
        Insert(newNode);

    }
}
