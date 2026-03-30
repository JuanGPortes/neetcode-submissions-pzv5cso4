public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string result = string.Empty;
        while(columnNumber > 0){
            int residue = (columnNumber - 1) % 26;
            char c = (char)('A' + residue);
            result = c + result;

            columnNumber =  (columnNumber - 1) / 26;

        }

        return result;
    }
}