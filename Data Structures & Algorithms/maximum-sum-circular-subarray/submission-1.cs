public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int len = nums.Length;
        int maxSum = nums[0];

        for(int i = 0; i < len; i++){
            int currentSum = 0;
            for(int j = 0; j < len; j++){
                int currentIndex = (i + j) % len;

                currentSum += nums[currentIndex];

                if(currentSum > maxSum){
                    maxSum = currentSum;
                }
            }
        }

        return maxSum;
    }
}