public class Solution {
    public string ConvertToTitle(int columnNumber) {
        
        StringBuilder builder = new StringBuilder();

        while(columnNumber > 0){
            columnNumber--;
            int residue = columnNumber % 26;
            char currentValue = (char)('A' + residue);
            builder.Append(currentValue);

            columnNumber /= 26;
        }

        char[] charArr = builder.ToString().ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
}