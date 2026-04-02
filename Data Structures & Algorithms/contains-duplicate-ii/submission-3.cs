public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length < 2){
            return false;
        }

        int n = nums.Length;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for(int i = 0; i < n; i++){
            if(map.TryGetValue(nums[i], out int j) && i - j <= k){
                return true;
            }

            map[nums[i]] = i;
        }

        return false;
    }
}