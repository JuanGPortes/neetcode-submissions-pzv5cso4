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
        if(pairs == null || pairs.Count <= 1){
            return pairs;
        }

        DivideAndMerge(pairs, 0, pairs.Count -1);


        return pairs;
    }

    private void DivideAndMerge(List<Pair> pairs, int left, int right){

        /// right - left + 1<= 1
        if(left >= right){
            return;
        }

        int middle = left + (right - left) / 2;

        DivideAndMerge(pairs, left, middle);
        DivideAndMerge(pairs, middle + 1, right);

        Merge(pairs, left, middle, right);
    }

    private void Merge(List<Pair> pairs, int left, int middle, int right){
        int leftLength = middle - left + 1;
        int rightLength = right - middle;

        Pair[] leftTemp = new Pair[leftLength];
        Pair[] rightTemp = new Pair[rightLength];

        for(int l = 0; l < leftLength; l++){
            leftTemp[l] = pairs[left + l];
        }

        for(int r = 0; r < rightLength; r++){
            rightTemp[r] = pairs[middle + 1 + r];
        }

        int i = 0;
        int j = 0;
        int k = left;

        while(i < leftLength && j < rightLength){
            if(leftTemp[i].Key <= rightTemp[j].Key){
                pairs[k] = leftTemp[i];
                i++;
            }
            else{
                pairs[k] = rightTemp[j];
                j++;
            }
            k++;
        }

        while(i < leftLength){
            pairs[k] = leftTemp[i];
            i++;
            k++;
        }

        while(j < rightLength){
            pairs[k] = rightTemp[j];
            j++;
            k++;
        }
    }

}
