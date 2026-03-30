public class LRUCache {

    private readonly int capacity;
    private readonly Dictionary<int, LinkedListNode<(int Key, int Value)>> _cache;
    private readonly LinkedList<(int Key, int Value)> _list;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        _cache = new Dictionary<int, LinkedListNode<(int Key, int Value)>>();
        _list = new LinkedList<(int Key, int Value)>();
    }
    
    public int Get(int key) {
        if(_cache.TryGetValue(key, out LinkedListNode<(int Key, int Value)> node)){
            _list.Remove(node);
            _list.AddFirst(node);
            return node.Value.Value;
        }
        else{
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if(_cache.TryGetValue(key, out LinkedListNode<(int Key, int Value)> node)){
            node.Value = (key, value);
            _list.Remove(node);
            _list.AddFirst(node);
            return;
        }
        else{
            if(_cache.Count >= capacity){
                LinkedListNode<(int Key, int Value)> lastNode = _list.Last;
                _cache.Remove(lastNode.Value.Key);
                _list.RemoveLast();
            }
        }

        LinkedListNode<(int Key, int Value)> newNode = _list.AddFirst((key, value));
        _cache[key] = newNode;
    }
}
