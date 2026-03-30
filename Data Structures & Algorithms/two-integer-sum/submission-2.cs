public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length == 0){
            return null;
        }

        var map = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++){
            int diff = target - nums[i];
            if(map.TryGetValue(diff, out int value)){
                return new int[] {value, i};
            }
            else{
                map[nums[i]] = i;
            }
        }

        return null;

    }
}
