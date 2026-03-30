public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums == null || nums.Length < 1){
            return -1;
        }
        
        int totalSum = 0;
        for(int i = 0; i < nums.Length; i++){
            totalSum += nums[i];
            nums[i] = totalSum;
        }

        int leftSum = 0;
        int rightSum = 0;
        for(int i = 0; i < nums.Length; i++){
            if(i != 0){
                leftSum = nums[i - 1];
            }

            rightSum = nums[nums.Length - 1];

            if(leftSum == (rightSum - nums[i]))
            {
                return i;
            }
        }

        return -1;
        
    }
}