public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        int n = nums.Length;

        int[] prefixSum = new int[n + 1];
        for(int i = 0; i < n; i++){
            prefixSum[i + 1] = nums[i] + prefixSum[i];
        }

        int minLen = n + 1;

        for(int i = 0; i < n; i++){
            int requiredSum = target + prefixSum[i];

            int left = i + 1;
            int right = n;
            int bestJ = -1;

            while(left <= right){
                int mid = left + (right - left) / 2;

                if(prefixSum[mid] >= requiredSum){
                    bestJ = mid;
                    right = mid - 1;
                }
                else{
                    left = mid + 1;
                }
            }
            
            if(bestJ != -1){
                minLen = Math.Min(minLen, bestJ - i);
            }
        }
        
        return minLen == n + 1 ? 0 : minLen;
    }
}