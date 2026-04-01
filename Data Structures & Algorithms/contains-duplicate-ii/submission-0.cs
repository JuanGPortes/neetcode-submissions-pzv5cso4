public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length < 2){
            return false;
        }

        int len = nums.Length;

        for(int i = 0; i < len; i++){
            for(int j = i + 1; j < len; j++){
                if(nums[i] == nums[j] && Math.Abs(i - j) <= k){
                    return true;
                }
            }
        }

        return false;
    }
}