public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int totalSum = 0;

        int globalMax = nums[0];
        int currentMax = 0;

        int globalMin = nums[0];
        int currentMin = 0;

        foreach(int num in nums){
            totalSum += num;

            currentMax = Math.Max(currentMax + num, num);
            globalMax = Math.Max(globalMax, currentMax);

            currentMin = Math.Min(currentMin + num, num);
            globalMin = Math.Min(globalMin, currentMin);
        }

        if(globalMax < 0){
            return globalMax;
        }

        return Math.Max(globalMax, totalSum - globalMin);
    }
}