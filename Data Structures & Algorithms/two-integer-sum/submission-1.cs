public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length == 0){
            return null;
        }

        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            map[nums[i]] = i;
        }

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(map.TryGetValue(diff, out int value) && 
               value != i){
                return new int[] {i, value};
            }
            else{
                map[nums[i]] = i;
            }
        }

        return null;

    }
}
