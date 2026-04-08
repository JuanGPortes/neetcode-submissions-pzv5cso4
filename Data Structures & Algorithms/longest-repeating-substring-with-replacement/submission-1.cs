public class Solution {
    public int CharacterReplacement(string s, int k) {
        if(string.IsNullOrEmpty(s)){
            return 0;
        }

        int maxLength = 0;
        HashSet<char> set = new HashSet<char>(s);

        foreach(char c in set){
            int left = 0;
            int count = 0;
            for(int right = 0; right < s.Length; right++){
                
                if(s[right] == c){
                    count++;
                }

                int currentWindow = right - left + 1;

                while(currentWindow - count > k){
                    if(s[left] == c){
                        count--;
                    }

                    left++;
                    currentWindow = right - left + 1;
                }

                maxLength = Math.Max(maxLength, currentWindow);
            }
        }

        return maxLength;
    }
}
