public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        if(arr == null || arr.Length == 0 || arr.Length < k){
            return 0;
        }

        int n = arr.Length;
        int left = 0;
        int totalArrays = 0;
        int totalSum = 0;
        threshold *= k;
    
        for(int right = 0; right < n; right++){
            if(right - left + 1 > k){
                totalSum -= arr[left];
                left++;
            }

            totalSum += arr[right];
            
            if(right - left + 1 == k){
                if(totalSum >= threshold){
                    totalArrays++;
                }
            }
        }

        return totalArrays;
    }
}