public class Solution {
    public int MinSubArrayLen(int target, int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int n = nums.Length;

        int totalSum = 0;
        int minLength = n + 1;
        int left = 0;

        for(int right = 0; right < n; right++){
            totalSum += nums[right];
            while(totalSum >= target){
                minLength = Math.Min(minLength, right - left + 1);
                
                totalSum -= nums[left];
                left++;
            }
        }

        if(minLength == n + 1){
            return 0;
        }

        return minLength;
    }
}