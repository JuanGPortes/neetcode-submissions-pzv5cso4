public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int count = 0;
        int totalSum = 0;

        Dictionary<int, int> prefixCounts = new Dictionary<int, int>();

        prefixCounts[0] = 1;

        for(int i = 0; i < nums.Length; i++){
            totalSum += nums[i];

            int targetPrefix = totalSum - k;

            if(prefixCounts.ContainsKey(targetPrefix)){
                count += prefixCounts[targetPrefix];
            }

            if(prefixCounts.ContainsKey(totalSum)){
                prefixCounts[totalSum]++;
            }
            else{
                prefixCounts[totalSum] = 1;
            }
        }

        return count;
    }
}