public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int left = 0;
        int maxLength = 0;
        var map = new Dictionary<char, int>();

        for(int right = 0; right < s.Length; right++){
            if(map.ContainsKey(s[right])){
                left = Math.Max(left, map[s[right]] + 1);
            }

            map[s[right]] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
