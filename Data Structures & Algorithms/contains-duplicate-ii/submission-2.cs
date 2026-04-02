public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length < 2){
            return false;
        }

        int n = nums.Length;

        for(int L = 0; L < n; L++){
            for(int R = L + 1; R < Math.Min(n, L + k + 1); R++){
                if(nums[L] == nums[R]){
                    return true;
                }
            }
        }

        return false;
    }
}