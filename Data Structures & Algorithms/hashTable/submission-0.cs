public class HashTable {
    
    private class Pair{
        public int Key { get; private set; }
        public int Val { get; set; }

        public Pair(int key, int val){
            Key = key;
            Val = val;
        }
    }

    private int Size { get; set; }
    private int Capacity { get; set; }
    private Pair[] Map { get; set; }

    private static readonly Pair TOMBSTONE = new Pair(-1, -1);

    public HashTable(int capacity) {
        Capacity = capacity;
        Size = 0;
        Map = new Pair[capacity];
    }

    public void Insert(int key, int value) {
        int index = GetHash(key);
        int tombstoneIndex = -1;
        while(Map[index] != null){
            if(Map[index] == TOMBSTONE){
                if(tombstoneIndex == -1){
                    tombstoneIndex = index;
                }
            }
            else if(Map[index].Key == key){
                Map[index].Val = value;

                return;
            }

            index = (index + 1) % Capacity;
        }

        index = tombstoneIndex != -1 ? tombstoneIndex : index;

        Map[index] = new Pair(key, value);
        Size += 1;

        if(Size >= Capacity / 2.0){
            Resize();
        }
    }

    public int Get(int key) {
        int index = GetHash(key);

        while(Map[index] != null){
            if(Map[index] != TOMBSTONE && Map[index].Key == key){
                return Map[index].Val;
            }

            index = (index + 1) % Capacity;
        }

        return -1;
    }

    public bool Remove(int key) {
        int index = GetHash(key);

        while(Map[index] != null){
            if(Map[index] != TOMBSTONE && Map[index].Key == key){
                Map[index] = null;
                Size -= 1;
                return true;
            }

            index = (index + 1) % Capacity;
        }

        return false;
    }

    public int GetSize() {
        return Size;
    }

    public int GetCapacity() {
        return Capacity;
    }

    public void Resize() {
        Capacity *= 2;
        Pair[] oldMap = Map;

        Map = new Pair[Capacity];
        Size = 0;

        foreach(Pair pair in oldMap){
            if(pair != null && pair != TOMBSTONE){
                Insert(pair.Key, pair.Val);
            }
        }
    }

    private int GetHash(int key){
        return key % Capacity;
    }

}
