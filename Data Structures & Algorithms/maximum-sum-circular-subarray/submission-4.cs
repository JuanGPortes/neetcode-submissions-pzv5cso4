public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int totalSum = 0;

        int globalMax = nums[0];
        int currentMax = 0;

        int globalMin = nums[0];
        int currentMin = 0;

        foreach(int num in nums){
            totalSum += num;

            currentMax = Math.Max(num, currentMax + num);
            globalMax = Math.Max(currentMax, globalMax);

            currentMin = Math.Min(num, currentMin + num);
            globalMin = Math.Min(currentMin, globalMin);
        }

        return globalMax < 0 ? globalMax : Math.Max(globalMax, totalSum - globalMin);
    }
}