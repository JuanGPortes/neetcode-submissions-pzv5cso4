public class Solution {
    public int MaxSubArray(int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int maxSum = nums[0];
        for(int i = 0; i < nums.Length; i++){
            int currentSum = 0;
            for(int j = i; j < nums.Length; j++){
                currentSum += nums[j];
                if(currentSum > maxSum){
                    maxSum = currentSum;
                }
            }
        }
        return maxSum;
    }

    

}
