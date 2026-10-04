public class MyLinkedList {

    private class Node{
        public int val;
        public Node prev;
        public Node next;

        public Node(int val, Node prev = null, Node next = null){
            this.val = val;
            this.prev = prev;
            this.next = next;
        }
    }

    private int size;
    private Node head;
    private Node tail;

    public MyLinkedList() {
        size = 0;

        head = new Node(-1);
        tail = new Node(-1);

        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int index) {
        if(index < 0 || index >= size){
            return -1;
        }

        Node current;
        if(index * 2 < size){
            current = head.next;
            for(int i = 0; i < index; i++){
                current = current.next;
            }
        }
        else{
            current = tail.prev;
            for(int i = size - 1; i > index; i--){
                current = current.prev;
            }
        }

        return current.val;
    }
    
    public void AddAtHead(int val) {
        Node newNode = new Node(val);
        Node nextTemp = head.next;

        newNode.prev = head;
        newNode.next = nextTemp;

        nextTemp.prev = newNode;
        head.next = newNode;

        size++;
    }
    
    public void AddAtTail(int val) {
        Node newNode = new Node(val);
        Node prevTemp = tail.prev;

        newNode.prev = prevTemp;
        newNode.next = tail;

        prevTemp.next = newNode;
        tail.prev = newNode;

        size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index > size){
            return;
        }

        if(index <= 0){
            AddAtHead(val);
            return;
        }

        if(index == size){
            AddAtTail(val);
            return;
        }

        Node current = GetNodeAt(index);

        Node newNode = new Node(val);
        Node tempPrev = current.prev;

        newNode.prev = tempPrev;
        newNode.next = current;

        current.prev = newNode;
        tempPrev.next = newNode;

        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || index >= size){
            return;
        }

        Node current = GetNodeAt(index);

        Node prevTemp = current.prev;
        Node nextTemp = current.next;

        prevTemp.next = nextTemp;
        nextTemp.prev = prevTemp;

        current.prev = null;
        current.next = null;

        size--;
    }

    private Node GetNodeAt(int index){
        Node current = null;
        if(index * 2 < size){
            current = head.next;
            for(int i = 0; i < index; i++){
                current = current.next;
            }
        }
        else {
            current = tail.prev;
            for(int i = size - 1; i > index; i--){
                current = current.prev;
            }
        }

        return current;
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