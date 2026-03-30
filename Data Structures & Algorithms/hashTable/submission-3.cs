public class HashTable {

    private class Node{
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value){
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private int Size;
    private int Capacity;
    private Node[] Map;

    public HashTable(int capacity) {
        Size = 0;
        Capacity = capacity;
        Map = new Node[capacity];
    }

    public void Insert(int key, int value) {
        int index = Hash(key);
        Node node = this.Map[index];

        while(node != null){
            if(node.Key == key){
                node.Value = value;
                return;
            }
            node = node.Next;
        }

        Node newNode = new Node(key, value);
        newNode.Next = Map[index];
        Map[index] = newNode;
        Size++;

        if(Size * 2 >= Capacity){
            Resize();
        }
    }

    public int Get(int key) {
        int index = Hash(key);
        Node node = Map[index];

        while(node != null){
            if(node.Key == key){
                return node.Value;
            }
            node = node.Next;
        }

        return -1;
    }

    public bool Remove(int key) {
        int index = Hash(key);
        Node node = Map[index];
        Node prev = null;

        while(node != null){
            if(node.Key == key){
                if(prev != null){
                    prev.Next = node.Next;
                }
                else{
                    Map[index] = node.Next;
                }

                Size--;
                return true;
            }
            prev = node;
            node = node.Next;
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
        int newCapacity = Capacity * 2;
        Node[] newMap = new Node[newCapacity];

        for(int i = 0; i < Capacity; i++){
            Node node = Map[i];

            while(node != null){
                Node nextNode = node.Next;

                int index = (node.Key % newCapacity + newCapacity) % newCapacity;

                node.Next = newMap[index];
                newMap[index] = node;

                node = nextNode;
            }
        }

        Capacity = newCapacity;
        Map = newMap;
    }

    public int Hash(int key){
        return (key % Capacity + Capacity) % Capacity;
    }
}
