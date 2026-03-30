public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)) return 0;

        int maxLength = 0;
        HashSet<char> chars = new HashSet<char>();

        int left = 0;
        for(int right = 0; right < s.Length; right++){
            char currentChar = s[right];

            while(chars.Contains(currentChar)){
                chars.Remove(s[left]);
                left++;
            }

            chars.Add(currentChar);
            int windowCurrentLength = right - left + 1;

            if(windowCurrentLength > maxLength){
                maxLength = windowCurrentLength;
            }
        }

        return maxLength;
    }
}
