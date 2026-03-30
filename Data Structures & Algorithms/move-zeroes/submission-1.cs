public class Solution {
    public void MoveZeroes(int[] nums) {
        int k = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != 0){
                if(i != k){
                    nums[k] = nums[i];
                    nums[i] = 0;
                }
                k++;
            }
        }
    }
}