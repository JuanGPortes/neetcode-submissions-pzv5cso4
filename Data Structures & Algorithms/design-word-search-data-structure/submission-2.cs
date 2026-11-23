public class WordDictionary {

    private class TrieNode{
        public bool isEndOfWord;
        public TrieNode[] children = new TrieNode[26];
    }

    private readonly TrieNode root;

    public WordDictionary() {
        root = new TrieNode();
    }
    
    public void AddWord(string word) {
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
        return Dfs(word, 0, root);
    }

    private bool Dfs(string word, int j, TrieNode root){
        TrieNode current = root;

        for(int i = j; i < word.Length; i++){
            char c = word[i];

            if(c == '.'){
                foreach(var child in current.children){
                    if(child != null && Dfs(word, i + 1, child)){
                        return true;
                    }
                }

                return false;
            }
            else{
                int index = c - 'a';
                if(current.children[index] == null){
                    return false;
                }
                current = current.children[index];
            }
        }

        return current.isEndOfWord;
    }
}
