public class Solution {
    public List<List<string>> GroupAnagrams1(string[] strs) {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            char[] charArray = strs[i].ToCharArray();
            Array.Sort(charArray);
            string sortedArray = new string(charArray);

            if(!anagrams.ContainsKey(sortedArray))
            {
                anagrams[sortedArray] = new List<string>();
            }

            anagrams[sortedArray].Add(strs[i]); 

        }

        return anagrams.Values.ToList();
    }
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs == null || strs.Length < 1){
            return null;
        }
        var anagrams = new Dictionary<string, List<string>>();
        foreach(var str in strs){
            //'a' = 0 to 'z' = 25
            int[] frequency = new int[26];
            foreach(var ch in str){
                //ascii 'a' = 99... z = '124'
                frequency[ch - 'a']++;
            }
            string key = string.Join(',', frequency);

            if(!anagrams.ContainsKey(key)){
                anagrams[key] = new List<string>();
            }

            anagrams[key].Add(str);
        }

        return anagrams.Values.ToList();
    }
}
