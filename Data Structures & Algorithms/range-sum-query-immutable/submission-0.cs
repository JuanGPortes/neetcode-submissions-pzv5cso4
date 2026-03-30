public class NumArray {
    private int[] prefixSum;
    public NumArray(int[] nums) {
        prefixSum = new int[nums.Length];
        int totalSum = 0;
        for(int i = 0; i < nums.Length; i++){
            totalSum += nums[i];
            prefixSum[i] = totalSum;
        }
    }
    
    public int SumRange(int left, int right) {
        return prefixSum[right] - (left <= 0 ? 0 : prefixSum[left - 1]);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */