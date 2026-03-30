public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;

        for(int i = 0; i < s.Length; i++){
            HashSet<int> seen = new HashSet<int>();
            int currentLength = 0;

            for(int j = i; j < s.Length; j++){
                char currentChar = s[j];

                if(seen.Contains(currentChar)){
                    break;
                }

                seen.Add(currentChar);
                currentLength++;

                if(currentLength > maxLength){
                    maxLength = currentLength;
                }
            }
        }

        return maxLength;
    }
}
