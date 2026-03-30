public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length){
            return false;
        }

        var d = new Dictionary<char, int>();

        foreach(char c in s){
            if(!d.ContainsKey(c)){
                d[c] = 1;
            }
            else{
                d[c]++;
            }
        }

        foreach(char c in t){
            if(!d.ContainsKey(c)
                || d[c] == 0){
                return false;
            }
            d[c]--;
        }

        return true;

    }
}
