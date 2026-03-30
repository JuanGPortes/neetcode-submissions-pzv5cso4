public class Solution {
    public string ConvertToTitle(int columnNumber) {
        string result = string.Empty;

        while(columnNumber > 0){
            //1-20
            //0-25
            columnNumber--;
            int unit = columnNumber % 26;
            char c = (char)('A' + unit);
            result = c + result;

            columnNumber /= 26;
        }

        return result;
    }
}