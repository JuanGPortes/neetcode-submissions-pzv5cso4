public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        if(arr == null || arr.Length == 0 || arr.Length < k){
            return 0;
        }

        int n = arr.Length;
        int targetSum = threshold * k;
        int result = 0;

        int[] prefix = new int[n + 1];
        prefix[0] = 0;

        for(int i = 0; i < n; i++){
            prefix[i + 1] = arr[i] + prefix[i];
        }

        for(int i = k; i <= n; i++){
            int currentSum = prefix[i] - prefix[i - k];
            
            if(currentSum >= targetSum){
                result++;
            }
        }

        return result;
    }
}