public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length < 1){
            return null;
        }

        Dictionary<int, int> d = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            d[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(d.ContainsKey(diff) && d[diff] != i){
                return new int[] { i, d[diff] };
            }
        }

        return null;

    }
}
