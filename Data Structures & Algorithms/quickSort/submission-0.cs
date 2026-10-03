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
    public List<Pair> QuickSort(List<Pair> pairs) {
        if(pairs == null || pairs.Count <= 1){
            return pairs;
        }

        QuickSortHelper(pairs, 0, pairs.Count - 1);

        return pairs;
    }

    private void QuickSortHelper(List<Pair> pairs, int left, int right){
        if(left >= right){
            return;
        }

        Pair pivot = pairs[right];
        int partitionIndex = left;

        for(int i = left; i < right; i++){
            if(pairs[i].Key < pivot.Key){
                Pair temp = pairs[partitionIndex];
                pairs[partitionIndex] = pairs[i];
                pairs[i] = temp;
                partitionIndex++;
            }
        }

        pairs[right] = pairs[partitionIndex];
        pairs[partitionIndex] = pivot;

        QuickSortHelper(pairs, left, partitionIndex - 1);
        QuickSortHelper(pairs, partitionIndex + 1, right);
    }
}
