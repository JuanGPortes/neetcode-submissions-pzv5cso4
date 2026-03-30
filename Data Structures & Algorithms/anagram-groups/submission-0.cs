public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
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
}
