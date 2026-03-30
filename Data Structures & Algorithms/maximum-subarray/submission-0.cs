public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int maxSum = nums[0];
        int currentSum = 0;

        for(int i = 0; i < nums.Length; i++){
            if(currentSum < 0){
                currentSum = 0;
            }

            currentSum += nums[i];

            if(currentSum > maxSum){
                maxSum = currentSum;
            }
        }

        return maxSum;
    }
}
