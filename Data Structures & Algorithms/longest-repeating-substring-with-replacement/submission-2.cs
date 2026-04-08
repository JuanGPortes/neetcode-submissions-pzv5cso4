public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int maxLength = 0;
        int maxFreq = 0;
        int left = 0;
        Dictionary<char, int> counts = new Dictionary<char, int>();

        for(int right = 0; right < s.Length; right++){
            if(!counts.ContainsKey(s[right])){
                counts[s[right]] = 0;
            }

            counts[s[right]]++;

            maxFreq = Math.Max(maxFreq, counts[s[right]]);

            while((right - left + 1) - maxFreq > k){
                counts[s[left]]--;

                left++;
            }

            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}
