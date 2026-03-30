public class DynamicArray {

    private int _capacity;
    private int _size;
    private int[] _arr;
    
    public DynamicArray(int capacity) {
        _size = 0;
        _capacity = capacity;
        _arr = new int[capacity];
    }

    public int Get(int i) {
        if(i < 0 || i >= _size){
            return 0;
        }

        return _arr[i];
    }

    public void Set(int i, int n) {
        if(i >= 0 && i < _size){
            _arr[i] = n;
        }
    }

    public void PushBack(int n) {
        if(_size >= _capacity){
            Resize();
        }

        _arr[_size++] = n;
    }

    public int PopBack() {
        if(_size > 0){
            return _arr[--_size];
        }

        return 0;
    }

    private void Resize() {
        int[] newArr = new int[_capacity * 2];

        for(int i = 0; i < _capacity; i++){
            newArr[i] = _arr[i];
        }

        _capacity *= 2;
        _arr = newArr;
    }

    public int GetSize() {
        return _size;
    }

    public int GetCapacity() {
        return _capacity;
    }
}
