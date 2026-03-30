public class DynamicArray {
    
    private int[] arr;
    private int capacity;
    private int length;

    public DynamicArray(int capacity) {
        arr = new int[capacity];
        this.capacity = capacity;
        length = 0;
    }

    public int Get(int i) {
        if (i < 0 || i >= arr.Length)
        {
            return 0;
        }
        return arr[i];
    }

    public void Set(int i, int n) {
        for (int j = length - 1; j > i + 1; i-- )
        {
            arr[j + 1] = arr[j];
        }

        arr[i] = n;
    }

    public void PushBack(int n) {
        if (length == capacity)
        {
            this.Resize();
        }

        arr[length] = n;
        length++;
    }

    public int PopBack() {
        int lastValue = arr[length - 1];
        length--;
        
        return lastValue;
    }

    private void Resize() {
        capacity = 2 * capacity;
        int[] newArr = new int[capacity];

        for (int i = 0; i < arr.Length; i++)
        {
            newArr[i] = arr[i];
        }

        arr = newArr;
    }

    public int GetSize() {
        return length;
    }

    public int GetCapacity() {
        return capacity;
    }
}
