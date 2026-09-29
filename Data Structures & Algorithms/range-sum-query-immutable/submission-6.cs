public class NumArray {

    private int[] sumArray;

    public NumArray(int[] nums) {
        sumArray = new int[nums.Length + 1];

        int currentSum = 0;
        for(int i = 0; i < nums.Length; i++){
            sumArray[i + 1] = sumArray[i] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        int rightSum = sumArray[right + 1];
        int leftSum = sumArray[left];

        return rightSum - leftSum;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */