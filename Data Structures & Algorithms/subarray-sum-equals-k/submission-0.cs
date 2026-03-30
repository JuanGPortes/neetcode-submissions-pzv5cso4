public class Solution {
    public int SubarraySum(int[] nums, int k) {
        if(nums == null || nums.Length < 1){
            return 0;
        }
        int count = 0;
        for(int i = 0; i < nums.Length; i++){
            int totalSum = 0;

            for(int j = i; j < nums.Length; j++){
                totalSum += nums[j];

                if(totalSum == k){
                    count++;
                }
            }
        }

        return count;
    }
}