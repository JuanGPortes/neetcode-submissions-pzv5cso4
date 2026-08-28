//using System.Linq;

public class MinStack {

    private Stack<int> _stack;

    public MinStack() {
        _stack = new Stack<int>();
    }
    
    public void Push(int val) {
        _stack.Push(val);
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _stack.Min();
    }
}
