public class MyLinkedList {
    
    private List<int> list;

    public MyLinkedList() {
        list = new List<int>();
    }
    
    public int Get(int index) {
        if(index < 0 || index >= list.Count){
            return -1;
        }

        return list[index];
    }
    
    public void AddAtHead(int val) {
        list.Insert(0, val);
    }
    
    public void AddAtTail(int val) {
        list.Add(val);
    }
    
    public void AddAtIndex(int index, int val) {
        if(index > list.Count){
            return;
        }

        if(index <= 0){
            AddAtHead(val);
            return;
        }

        if(index == list.Count){
            AddAtTail(val);
        }
        else{
            list.Insert(index, val);
        }
    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || index >= list.Count){
            return;
        }

        list.RemoveAt(index);
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */