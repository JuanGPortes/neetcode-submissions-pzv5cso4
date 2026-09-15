public class BrowserHistory {

    private List<string> history;
    private int currentIdx;

    public BrowserHistory(string homepage) {
        history = new List<string>(){
            homepage
        };

        currentIdx = 0;
    }
    
    public void Visit(string url) {
        int elementsToRemove = history.Count - (currentIdx + 1);
        if(elementsToRemove > 0){
            history.RemoveRange(currentIdx + 1, elementsToRemove);
        }

        history.Add(url);
        currentIdx++;
    }
    
    public string Back(int steps) {
        currentIdx = Math.Max(0, currentIdx - steps);
        return history[currentIdx];
    }
    
    public string Forward(int steps) {
        currentIdx = Math.Min(history.Count - 1, currentIdx + steps);
        return history[currentIdx];
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */