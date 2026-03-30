public class HashTable {

    private class Pair{
        public int Key;
        public int Value;

        public Pair(int key, int val){
            Key = key;
            Value = val;
        }
    }

    private int Size;
    private int Capacity;
    private Pair[] Map;

    private Pair TOMBSTONE = new Pair(-1, -1);

    public HashTable(int capacity) {
        Size = 0;
        Capacity = capacity;
        Map = new Pair[capacity];
    }

    public void Insert(int key, int value) {
        int index = Hash(key);
        int tombstoneIndex = -1;

        while(Map[index] != null){
            if(Map[index] == TOMBSTONE){
                if(tombstoneIndex == -1){
                    tombstoneIndex = index;
                }
            }
            else if(Map[index].Key == key){
                Map[index].Value = value;
                
                return;
            }

            index = (index + 1) % Capacity;
        }

        index = tombstoneIndex != -1 ? tombstoneIndex : index;

        Map[index] = new Pair(key, value);
        Size += 1;

        if(Size * 2 >= Capacity){
            Resize();
        }
    }

    public void InsertNode(int key, int value) {
        int index = Hash(key);
        int tombstoneIndex = -1;

        while(Map[index] != null){
            if(Map[index] == TOMBSTONE){
                if(tombstoneIndex == -1){
                    tombstoneIndex = index;
                }
            }
            else if(Map[index].Key == key){
                Map[index].Value = value;
                
                return;
            }

            index = (index + 1) % Capacity;
        }

        index = tombstoneIndex != -1 ? tombstoneIndex : index;

        Map[index] = new Pair(key, value);
        Size += 1;
    }

    public int Get(int key) {
        int index = Hash(key);

        while(Map[index] != null){
            if(Map[index] != TOMBSTONE && Map[index].Key == key){
                return Map[index].Value;
            }

            index = (index + 1) % Capacity;
        }

        return -1;
    }

    public bool Remove(int key) {
        int index = Hash(key);

        while(Map[index] != null){
            if(Map[index] != TOMBSTONE && Map[index].Key == key){
                Map[index] = TOMBSTONE;
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
                InsertNode(pair.Key, pair.Value);
            }
        }
    }

    private int Hash(int key){
        return ((key % Capacity) + Capacity) % Capacity;
    }
}
