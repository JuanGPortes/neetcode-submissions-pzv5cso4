public class LRUCache {

    private readonly int[] _used;
    private readonly int _capacity;
    private int _length; 
    private readonly Dictionary<int, int> _cache;

    public LRUCache(int capacity) {
        _capacity = capacity;
        _length = 0;
        _used = new int[capacity];
        _cache = new Dictionary<int, int>();
    }

    void Remove(int key){
        int index = -1;
        for(int i = 0; i < _length; i++){
            if(key == _used[i]){
                index = i;
            }
        }

        if(index > -1){
            RemoveAt(index);
        }
    }

    void RemoveAt(int index){
        for(int i = index + 1; i < _length; i++){
            _used[i - 1] = _used[i];
        }
        _length--;
    }

    void Insert(int key){
        _used[_length] = key;
        _length++;
    }
    
    public int Get(int key) {
        if(_cache.TryGetValue(key, out int value)){
            Remove(key);
            Insert(key);
            return value;
        }
        else{
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if(_cache.ContainsKey(key)){
            Remove(key);
        }
        else{
            if(_cache.Count >= _capacity){
                _cache.Remove(_used[0]);
                RemoveAt(0);
            }
        }

        Insert(key);
        _cache[key] = value;
    }
}
