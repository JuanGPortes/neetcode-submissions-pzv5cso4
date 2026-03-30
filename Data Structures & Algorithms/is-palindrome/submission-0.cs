public class Solution {
    public bool IsPalindrome(string s) {
        StringBuilder builder = new StringBuilder();

        foreach(char c in s){
            if(char.IsLetterOrDigit(c)){
                builder.Append(char.ToLower(c));
            }
        }

        string newString = builder.ToString();

        char[] charArray = newString.ToCharArray();
        Array.Reverse(charArray);
        string reversedString = new string(charArray);

        return newString == reversedString;
    }
}
