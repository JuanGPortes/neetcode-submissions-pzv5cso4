public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs == null || strs.Length < 1){
            return new List<List<string>>();
        }

        var anagrams = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            //'a' == 97 - 'z' == 124
            int[] count = new int[26];
            for(int j = 0; j < strs[i].Length; j++){
                count[(strs[i])[j] - 'a']++;
            }

            string key = string.Join(',', count);

            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(strs[i]);
        }

        return anagrams.Values.ToList();
    }
}
