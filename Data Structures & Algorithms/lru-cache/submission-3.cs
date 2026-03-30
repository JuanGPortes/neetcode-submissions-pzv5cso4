public class LRUCache {

    private readonly int capacity;
    private readonly Dictionary<int, int> cache;
    private readonly List<int> used;

    public LRUCache(int capacity) {
        this.capacity = capacity;
        cache = new Dictionary<int, int>();
        used = new List<int>();
    }
    
    public int Get(int key) {
        if(cache.TryGetValue(key, out int value)){
            used.Remove(key);
            used.Add(key);
            return value;
        }
        else{
            return -1;
        }
    }
    
    public void Put(int key, int value) {
        if(cache.ContainsKey(key)){
            used.Remove(key);
        }
        else{
            if(cache.Count >= capacity){
                cache.Remove(used[0]);
                used.RemoveAt(0);
            }
        }

        used.Add(key);
        cache[key] = value;
    }
}
