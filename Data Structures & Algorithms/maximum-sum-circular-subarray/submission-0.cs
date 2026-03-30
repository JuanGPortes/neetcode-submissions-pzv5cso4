public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int maxSum = nums[0];
        int n = nums.Length;

        for(int i = 0; i < n; i++){
            int currentSum = 0;
            for(int j = i; j < i + n; j++){
                int currentIndex = j % n;
                currentSum += nums[currentIndex];

                if(currentSum > maxSum){
                    maxSum = currentSum;
                }
            }
        }

        return maxSum;
    }
}