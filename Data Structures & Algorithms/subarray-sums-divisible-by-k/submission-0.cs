public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int n = nums.Length;
        int res = 0;

        for(int i = 0; i < n; i++){
            int currentSum = 0;
            for(int j = i; j < n; j++){
                currentSum += nums[j];
                if(((currentSum % k) + k) % k == 0){
                    res++;
                }
            }
        }

        return res;
    }
}