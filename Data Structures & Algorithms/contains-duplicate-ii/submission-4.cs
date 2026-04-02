public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if(nums == null || nums.Length < 2){
            return false;
        }

        int n = nums.Length;

        int left = 0;
        HashSet<int> window = new HashSet<int>();

        for(int right = 0; right < n; right++){
            if(right - left > k){
                window.Remove(nums[left]);
                left++;
            }

            if(window.Contains(nums[right])){
                return true;
            }

            window.Add(nums[right]);
        }

        return false;
    }
}