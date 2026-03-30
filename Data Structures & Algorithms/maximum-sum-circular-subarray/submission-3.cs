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

            if(currentMax + num > num){
                currentMax += num;
            }
            else{
                currentMax = num;
            }

            if(currentMax > globalMax){
                globalMax = currentMax;
            }

            if(currentMin + num < num){
                currentMin += num;
            }
            else{
                currentMin = num;
            }

            if(currentMin < globalMin){
                globalMin = currentMin;
            }
        }

        if(globalMax < 0){
            return globalMax;
        }

        if(globalMax > totalSum - globalMin){
            return globalMax;
        }

        return totalSum - globalMin;
    }
}