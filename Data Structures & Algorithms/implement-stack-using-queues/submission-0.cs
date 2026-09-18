public class MyStack {

    private class Node {
        public int val;
        public Node prev;
        public Node next;

        public Node(int val){
            this.val = val;
            this.prev = null;
            this.next = null;
        }
    }

    private Node head;
    private Node tail;

    private int size;

    public MyStack() {
        size = 0;

        head = new Node(-1);
        tail = new Node(-1);

        head.next = tail;
        tail.prev = head;
    }
    
    public void Push(int x) {
        Node newNode = new Node(x);
        Node prevNode = tail.prev;

        newNode.next = tail;
        newNode.prev = prevNode;

        tail.prev = newNode;
        prevNode.next = newNode;

        size++;
    }
    
    public int Pop() {
        Node prevNode = tail.prev;

        tail.prev = prevNode.prev;
        prevNode.prev.next = tail;

        prevNode.prev = null;
        prevNode.next = null;

        size--;

        return prevNode.val;
    }
    
    public int Top() {
        return tail.prev.val;
    }
    
    public bool Empty() {
        return size == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */