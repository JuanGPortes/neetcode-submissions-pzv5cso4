public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        if(arr == null || arr.Length == 0 || arr.Length < k){
            return 0;
        }

        int totalSum = 0;
        int res = 0;
        int targetSum = threshold * k;

        for(int i = 0; i < k; i++){
            totalSum += arr[i];
        }

        if(totalSum >= targetSum){
            res++;
        }

        for(int i = k; i < arr.Length; i++){
            totalSum += arr[i];
            totalSum -= arr[i - k];

            if(totalSum >= targetSum){
                res++;
            }
        }

        return res;
    }
}