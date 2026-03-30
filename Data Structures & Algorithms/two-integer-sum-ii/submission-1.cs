public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers == null || numbers.Length < 1){
            return Array.Empty<int>();
        }

        int len = numbers.Length;

        for(int i = 0; i < len; i++){
            for(int j = i + 1; j < len; j++){
                if(numbers[i] + numbers[j] == target){
                    return new int[] { i + 1, j + 1 };
                }
            }
        }

        return Array.Empty<int>();
    }
}
