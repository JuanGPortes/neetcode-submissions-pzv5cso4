public class Solution {
    public bool IsAnagram(string s, string t) {

        char[] charArrayS = s.ToCharArray();
        Array.Sort(charArrayS);
        string sortedS = new string(charArrayS);
        char[] charArrayT = t.ToCharArray();
        Array.Sort(charArrayT);
        string sortedT = new string(charArrayT);

        return sortedS == sortedT;

    }
}
