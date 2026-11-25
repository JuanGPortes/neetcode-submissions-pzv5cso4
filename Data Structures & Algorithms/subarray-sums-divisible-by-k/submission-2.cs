public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        if(nums == null || nums.Length == 0){
            return 0;
        }

        int counts = 0;
        int totalSum = 0;
        int length = nums.Length;

        int[] residues = new int[k];
        residues[0] = 1;

        for(int i = 0; i < length; i++){
            totalSum = ((totalSum + nums[i]) % k + k) % k;
            counts += residues[totalSum];
            residues[totalSum]++;
        }

        return counts;
    }
}