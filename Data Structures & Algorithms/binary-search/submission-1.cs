public class Solution {
    public int Search(int[] nums, int target) {
        if(nums.Length < 1){
            return -1;
        }
        
        int left = 0, right = nums.Length - 1, mid = 0;

        while(left <= right){
            mid = left + (right - left) / 2;

            if(target > nums[mid]){
                left = mid + 1;
            }
            else if(target < nums[mid]){
                right = mid - 1;
            }
            else{
                return mid;
            }
        }
        return -1;
    }
}
