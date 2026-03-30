public class HashTable {

    private class Pair{
        public int Key;
        public int Value;

        public Pair(int key, int value){
            Key = key;
            Value = value;
        }
    }

    private int Capacity;
    private int Size;
    private Pair[] Map;

    private static readonly Pair TOMBSTONE = new Pair(-1, -1);

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
        Size++;

        if(Size * 2 >= Capacity){
            Resize();
        }
    }

    private void InsertNode(int key, int value) {
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
        Size++;
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
                Size--;

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

        Size = 0;
        Map = new Pair[Capacity];

        foreach(Pair pair in oldMap){
            if(pair != null && pair != TOMBSTONE){
                InsertNode(pair.Key, pair.Value);
            }
        }
    }

    private int Hash(int key){
        return (key % Capacity + Capacity) % Capacity;
    }
}
