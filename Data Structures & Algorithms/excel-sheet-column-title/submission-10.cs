public class Solution {
    public string ConvertToTitle(int columnNumber) {
        
        StringBuilder builder = new StringBuilder();

        while(columnNumber > 0){
            columnNumber--;
            int residue = columnNumber % 26;
            char currentValue = (char)('A' + residue);
            builder.Insert(0, currentValue);

            columnNumber /= 26;
        }

        return builder.ToString();
    }
}