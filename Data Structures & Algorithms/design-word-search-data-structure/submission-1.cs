public class WordDictionary {

    private class TrieNode{
        public bool isEndOfWord;
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
    }

    private readonly TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
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
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int j, TrieNode root){
        TrieNode current = root;

        for(int i = j; i < word.Length; i++){
            char c = word[i];
            if(c == '.'){
                foreach(var child in current.children.Values){
                    if(Dfs(word, i + 1, child)){
                        return true;
                    }
                }

                return false;
            } else{
                if(!current.children.TryGetValue(c, out var node)){
                    return false;
                }
                current = node;
            }
        }

        return current.isEndOfWord;
    }
}
