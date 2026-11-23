public class WordDictionary {

    List<string> _words;

    public WordDictionary() {
        _words = new List<string>();
    }
    
    public void AddWord(string word) {
        _words.Add(word);
    }
    
    public bool Search(string word) {
        foreach(string w in _words){
            if(word.Length != w.Length){
                continue;
            }

            bool isMatch = true;
            for(int i = 0; i < word.Length; i++){
                if(word[i] != '.' && word[i] != w[i]){
                    isMatch = false;
                    break;
                }
            }

            if(isMatch){
                return true;
            }
        }

        return false;
    }
}
