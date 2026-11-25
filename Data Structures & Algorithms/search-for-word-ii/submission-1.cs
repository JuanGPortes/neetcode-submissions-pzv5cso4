public class Solution {
    private class TrieNode {
        public string? word;
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();

        public void AddWord(string word) {
            TrieNode current = this;

            foreach(char ch in word) {
                if (!current.children.TryGetValue(ch, out var node)) {
                    node = new TrieNode();
                    current.children[ch] = node;
                }
                current = node;
            }
            current.word = word;
        }
    }

    (int row, int col)[] directions = new (int row, int col)[]{
        (0, 1),
        (1, 0),
        (0, -1),
        (-1, 0)
    };

    public List<string> FindWords(char[][] board, string[] words) {
        List<string> result = new List<string>();

        if(board == null || board.Length == 0 || board[0].Length == 0 ||
           words == null || words.Length == 0){
            return result;
        }

        int rows = board.Length;
        int cols = board[0].Length;

        TrieNode root = new TrieNode();

        foreach(string word in words){
            if(string.IsNullOrEmpty(word)){
                continue;
            }

            root.AddWord(word);
        }

        for(int row = 0; row < rows; row++){
            for(int col = 0; col < cols; col++){
                if(root.children.ContainsKey(board[row][col])){
                    Dfs(board, row, col, root, result);
                }
            }
        }

        return result;
    }

    private void Dfs(char[][] board, int row, int col, TrieNode parent, List<string> result){
        if(row < 0 || row >= board.Length ||
           col < 0 || col >= board[0].Length){
            return;
        }

        char ch = board[row][col];

        if(ch == '#' || !parent.children.TryGetValue(ch, out TrieNode current)){
            return;
        }

        if(current.word != null){
            result.Add(current.word);
            current.word = null;
        }

        board[row][col] = '#';

        foreach(var dir in directions){
            Dfs(board, row + dir.row, col + dir.col, current, result);
        }

        board[row][col] = ch;

        if(current.children.Count == 0){
            parent.children.Remove(ch);
        }
    }
}
