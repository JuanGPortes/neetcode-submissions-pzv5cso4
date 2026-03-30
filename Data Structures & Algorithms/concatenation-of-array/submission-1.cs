public class Solution {
    public int[] GetConcatenation(int[] nums) {
        if(nums == null || nums.Length < 1){
            return new int[0];
        }

        int[] ans = new int[nums.Length * 2];
        int n = nums.Length;

        for(int i = 0; i < n; i++){
            ans[i] = nums[i];
            ans[n + i] = nums[i];
        }

        return ans;
    }
}