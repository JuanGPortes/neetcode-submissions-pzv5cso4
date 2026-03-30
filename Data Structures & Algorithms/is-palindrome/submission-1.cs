public class Solution {
    public bool IsPalindrome(string s) {
        int L = 0, R = s.Length - 1;

        while(L < R){
            while(L < R && !char.IsLetterOrDigit(s[L])){
                L++;
            }

            while(R > L && !char.IsLetterOrDigit(s[R])){
                R--;
            }

            if(char.ToLower(s[L]) != char.ToLower(s[R])){
                return false;
            }

            L++;
            R--;
        }

        return true;
    }
}
