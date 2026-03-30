public class Solution {
    public string ConvertToTitle(int columnNumber) {
        if(columnNumber == 0){
            return string.Empty;
        }

        return ConvertToTitle((columnNumber - 1) / 26) + (char)('A' + (columnNumber - 1 ) % 26);
    }
}