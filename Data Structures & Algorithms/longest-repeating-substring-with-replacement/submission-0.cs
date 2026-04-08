public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int maxLength = 0;

        for(int i = 0; i < s.Length; i++){
            Dictionary<char, int> counts = new Dictionary<char, int>();
            int maxFreq = 0;
            for(int j = i; j < s.Length; j++){
                char currentChar = s[j];
                if(!counts.ContainsKey(currentChar)){
                    counts[currentChar] = 0;
                }

                counts[currentChar]++;

                maxFreq = Math.Max(maxFreq, counts[currentChar]);
                
                int replacements = (j - i + 1) - maxFreq;
                if(replacements <= k){
                    maxLength = Math.Max(maxLength, j - i + 1);
                }
                else{
                    break;
                }
            }
        }

        return maxLength;
    }
}
