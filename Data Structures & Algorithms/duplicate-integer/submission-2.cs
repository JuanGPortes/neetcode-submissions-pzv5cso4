public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length < 1){
            return false;
        }

        HashSet<int> hs = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){
            if(!hs.Add(nums[i])){
                return true;
            }
        }

        return false;
    }
}
