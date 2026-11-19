public class PrefixTree {

    private class TrieNode{
        public bool isEndOfWord;
        public TrieNode[] children = new TrieNode[26];
    }

    private readonly TrieNode root;

    public PrefixTree() {
        root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        foreach(char c in word){
            int index = c - 'a';
            if(current.children[index] == null){
                current.children[index] = new TrieNode();
            }
            current = current.children[index];
        }
        current.isEndOfWord = true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        foreach(char c in word){
            int index = c - 'a';
            if(current.children[index] == null){
                return false;
            }
            current = current.children[index];
        }
        
        return current.isEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach(char c in prefix){
            int index = c - 'a';
            if(current.children[index] == null){
                return false;
            }
            current = current.children[index];
        }

        return true;
    }
}
