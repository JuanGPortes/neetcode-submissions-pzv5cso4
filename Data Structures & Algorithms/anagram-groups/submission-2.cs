public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        if(strs == null || strs.Length < 1){
            return null;
        }

        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            
            int[] count = new int[26];
            CharEnumerator enumerator = strs[i].GetEnumerator();
            while(enumerator.MoveNext()){
                char ch = enumerator.Current;
                count[ch - 'a']++;
            }

            string key = string.Join(',', count);
            
            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(strs[i]);

        }

        return anagrams.Values.OrderBy(x => x.FirstOrDefault()).ToList();

    }
       
}
