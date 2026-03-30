public class NumArray {

    int[] _nums;

    public NumArray(int[] nums) {
        int sum = 0;
        _nums = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++){
            sum += nums[i];
            _nums[i] = sum;
        }
    }
    
    public int SumRange(int left, int right) {
        return _nums[right] - (left <= 0 ? 0 : _nums[left - 1]);
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */