public class PrefixTree {

    private class TrieNode{
        public bool isEndOfWord;
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    }

    private readonly TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        foreach(char c in word){
            if(!current.children.TryGetValue(c, out var node)){
                node = new TrieNode();
                current.children[c] = node;
            }
            current = node;
        }
        current.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        foreach(char c in word){
            if(!current.children.TryGetValue(c, out var node)){
                return false;
            }
            current = node;
        }
        return current.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach(char c in prefix){
            if(!current.children.TryGetValue(c, out var node)){
                return false;
            }
            current = node;
        }
        return true;
    }
}
