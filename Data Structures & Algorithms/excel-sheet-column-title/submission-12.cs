public class Solution {
    public string ConvertToTitle(int columnNumber) {
        StringBuilder sb = new StringBuilder();

        while(columnNumber > 0){
            columnNumber--;
            int residue = columnNumber % 26;
            char currentChar = (char)(residue + 'A');

            sb.Append(currentChar);

            columnNumber /= 26;
        }
        
        char[] arr = new char[sb.Length];
        sb.CopyTo(0, arr, 0, sb.Length);
        Array.Reverse(arr);
        
        return new string(arr);
    }
}