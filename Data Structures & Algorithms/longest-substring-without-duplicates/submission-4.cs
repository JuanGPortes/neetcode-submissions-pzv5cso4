public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int left = 0;
        int maxLength = 0;
        int[] counts = new int[256]; //cold be 128 or 256 extended

        Array.Fill(counts, -1);

        for(int right = 0; right < s.Length; right++){
            if(counts[s[right]] != -1){
                left = Math.Max(left, counts[s[right]] + 1);
            }

            counts[s[right]] = right;

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
