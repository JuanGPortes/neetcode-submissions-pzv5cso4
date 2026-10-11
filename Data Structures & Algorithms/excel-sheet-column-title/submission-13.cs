public class Solution {
    public string ConvertToTitle(int columnNumber) {
        char[] buffer = new char[8];
        int index = buffer.Length;

        while(columnNumber > 0){
            columnNumber--;
            index--;
            buffer[index] = (char)('A' + (columnNumber % 26));
            columnNumber /= 26;
        }

        return new string(buffer, index, buffer.Length - index);
    }
}