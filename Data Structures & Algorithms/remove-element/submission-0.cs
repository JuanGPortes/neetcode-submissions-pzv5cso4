public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums == null || nums.Length < 1){
            return 0;
        }

        int index = 0;
        for(int i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[index] = nums[i];
                index++;
            }
        }

        return index;
    }
}