public class BrowserHistory {

    private class Node{
        public string url;
        public Node prev;
        public Node next;

        public Node(string url){
            this.url = url;
            this.prev = null;
            this.next = null;
        }
    }

    private Node current;

    public BrowserHistory(string homepage) {
        current = new Node(homepage);
    }
    
    public void Visit(string url) {
        Node newNode = new Node(url);

        current.next = newNode;
        
        newNode.prev = current;

        current = newNode;
    }
    
    public string Back(int steps) {
        while(current.prev != null && steps > 0){
            current = current.prev;
            steps--;
        }

        return current.url;
    }
    
    public string Forward(int steps) {
        while(current.next != null && steps > 0){
            current = current.next;
            steps--;
        }
        
        return current.url;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */