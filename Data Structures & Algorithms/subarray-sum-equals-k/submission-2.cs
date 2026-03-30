public class Solution {
    public int SubarraySum(int[] nums, int k) {
        if(nums == null || nums.Length < 1){
            return 0;
        }
        
        int len = nums.Length;
        int subArrayCount = 0;
        int totalSum = 0;

        Dictionary<int, int> prefixes = new Dictionary<int, int>();
        prefixes[0] = 1;

        for(int i = 0; i < len; i++){
            totalSum += nums[i];

            int prefix = totalSum - k;
            if(prefixes.TryGetValue(prefix, out int count)){
                subArrayCount += count;
            }

            if(prefixes.ContainsKey(totalSum)){
                prefixes[totalSum]++;
            }
            else{
                prefixes[totalSum] = 1;
            }
        }

        return subArrayCount;
    }
}