public class Solution {
    public int RemoveDuplicates(int[] nums) {
      if(nums == null || nums.Length < 1){
        return 0;
      }

      HashSet<int> uniques = new HashSet<int>();
      int length = nums.Length;

      for(int i = 0; i < length; i++){
        uniques.Add(nums[i]);
      }

      int index = 0;
      foreach(int num in uniques.OrderBy(x => x)){
        nums[index] = num;
        index++;
      }

      return index;
    }
}