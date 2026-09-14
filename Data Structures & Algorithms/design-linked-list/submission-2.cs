public class MyLinkedList {

    private class ListNode{
        public int val;
        public ListNode prev;
        public ListNode next;

        public ListNode(int val){
            this.val = val;
            this.prev = null;
            this.next = null;
        }
    }

    private ListNode head;
    private ListNode tail;

    private int size;

    public MyLinkedList() {
        head = new ListNode(-1);
        tail = new ListNode(-1);

        size = 0;

        head.next = tail;
        tail.prev = head;
    }
    
    public int Get(int index) {
        if(index < 0 || index >= size){
            return -1;
        }

        ListNode curr;

        if(index * 2 < size){
            curr = head.next;
            for(int i = 0; i < index; i++){
                curr = curr.next;
            }
        }
        else{
            curr = tail.prev;
            for(int i = size - 1; i > index; i--){
                curr = curr.prev;
            }
        }

        return curr.val;
    }
    
    public void AddAtHead(int val) {
        ListNode newNode = new ListNode(val);
        ListNode nextNode = head.next;

        newNode.next = nextNode;
        newNode.prev = head;

        head.next = newNode;
        nextNode.prev = newNode;

        size++;
    }
    
    public void AddAtTail(int val) {
        ListNode newNode = new ListNode(val);
        ListNode prevNode = tail.prev;

        newNode.next = tail;
        newNode.prev = prevNode;

        tail.prev = newNode;
        prevNode.next = newNode;

        size++;
    }
    
    public void AddAtIndex(int index, int val) {
        if(index > size){
            return;
        }

        if(index == size){
            AddAtTail(val);
            return;
        }

        if(index <= 0){
            AddAtHead(val);
            return;
        }

        ListNode curr;

        if(index * 2 < size){
            curr = head.next;
            for(int i = 0; i < index; i++){
                curr = curr.next;
            }
        }
        else{
            curr = tail.prev;
            for(int i = size - 1; i > index; i--){
                curr = curr.prev;
            }
        }

        ListNode newNode = new ListNode(val);
        ListNode prevNode = curr.prev;

        newNode.next = curr;
        newNode.prev = prevNode;

        curr.prev = newNode;
        prevNode.next = newNode;

        size++;
    }
    
    public void DeleteAtIndex(int index) {
        if(index < 0 || index >= size){
            return;
        }

        ListNode curr;

        if(index * 2 < size){
            curr = head.next;
            for(int i = 0; i < index; i++){
                curr = curr.next;
            }
        }
        else{
            curr = tail.prev;
            for(int i = size - 1; i > index; i--){
                curr = curr.prev;
            }
        }

        ListNode nextNode = curr.next;
        ListNode prevNode = curr.prev;

        nextNode.prev = prevNode;
        prevNode.next = nextNode;

        curr.next = null;
        curr.prev = null;

        size--;
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