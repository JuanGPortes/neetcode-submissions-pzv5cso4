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

    private readonly int _capacity;
    private readonly Dictionary<int, Node> _cache;
    private readonly Node _left;
    private readonly Node _right;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _cache = new Dictionary<int, Node>();
        _left = new Node(0, 0);
        _right = new Node(0, 0);
        _left.Next = _right;
        _right.Prev = _left;
    }

    void Pop(Node node){
        Node prev = node.Prev;
        Node next = node.Next;

        prev.Next = next;
        next.Prev = prev;
    }

    void Push(Node node){
        Node prev = _right.Prev;
        Node next = _right;

        prev.Next = node;
        next.Prev = node;

        node.Prev = prev;
        node.Next = next;
    }
    
    public int Get(int key) {
        if(_cache.TryGetValue(key, out Node node)){
            Pop(node);
            Push(node);
            return node.Value;
        }
        else{
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if(_cache.TryGetValue(key, out Node node)){
            Pop(node);
            Push(node);
            node.Value = value;
            return;
        }
        else{
            if(_cache.Count >= _capacity){
                Node oldNode = _left.Next;
                Pop(oldNode);
                _cache.Remove(oldNode.Key);
            }
        }
        
        Node newNode = new Node(key, value);
        Push(newNode);
        _cache[key] = newNode;
    }
}
