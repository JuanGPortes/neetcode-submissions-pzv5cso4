public class Solution {
    public int PivotIndex(int[] nums) {
        if(nums == null || nums.Length < 1){
            return -1;
        }

        int totalSum = 0;
        foreach(int num in nums){
            totalSum += num;
        }

        int leftSum = 0;
        int rightSum = 0;
        for(int i = 0; i < nums.Length; i++){
            rightSum = totalSum - leftSum - nums[i];

            if(leftSum == rightSum){
                return i;
            }

            leftSum += nums[i];
        }

        return -1;
    }
}