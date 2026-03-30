public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string result = string.Empty;
        while(columnNumber > 0){
            columnNumber--;
            int residue = columnNumber % 26;
            char ch = (char)('A' + residue);
            result = ch + result;
            columnNumber /= 26;
        }
        return result;
    }
}