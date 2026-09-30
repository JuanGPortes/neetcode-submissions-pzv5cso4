// Definition for a pair.
// public class Pair {
//     public int Key;
//     public string Value;
//
//     public Pair(int key, string value) {
//         Key = key;
//         Value = value;
//     }
// }
public class Solution {
    public List<Pair> MergeSort(List<Pair> pairs) {
        int n = pairs.Count;

        for(int i = 0; i < n - 1; i++){
            for(int j = 0; j < n - i - 1; j++){
                if(pairs[j].Key > pairs[j + 1].Key){
                    Pair temp = pairs[j + 1];
                    pairs[j + 1] = pairs[j];
                    pairs[j] = temp;
                }
            }
        }

        return pairs;
    }

}
