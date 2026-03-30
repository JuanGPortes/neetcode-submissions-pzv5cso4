public class Solution {
    public string ConvertToTitle(int columnNumber) {
        
        if(columnNumber == 0){
            return string.Empty;
        }
        columnNumber--;
        return ConvertToTitle(columnNumber/26) +
            (char)('A' + (columnNumber % 26));

    }
}