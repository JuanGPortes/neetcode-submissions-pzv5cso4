public class PrefixTree {

    HashSet<string> words;

    public PrefixTree() {
        words = new HashSet<string>();
    }
    
    public void Insert(string word) {
        words.Add(word);
    }
    
    public bool Search(string word) {
        return words.Contains(word);
    }
    
    public bool StartsWith(string prefix) {
        foreach(string word in words){
            if(word.StartsWith(prefix, StringComparison.Ordinal)){
                return true;
            }
        }

        return false;
    }
}
