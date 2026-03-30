public class Solution {
    public string ConvertToTitle(int columnNumber) {

        string result = string.Empty;

        while(columnNumber > 0){
            int residue = (columnNumber - 1) % 26;
            char ch = (char)('A' + residue);
            result = ch + result;

            columnNumber = (columnNumber - 1) / 26;
        }

        return result;
    }
}