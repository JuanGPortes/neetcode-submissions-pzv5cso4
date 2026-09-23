public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        int count = 0;
        int currentSum = 0;

        Dictionary<int, int> remainderCounts = new Dictionary<int, int>();

        remainderCounts[0] = 1;

        for(int i = 0; i < nums.Length; i++){
            currentSum += nums[i];

            int remainder = (((currentSum % k) + k)) % k;

            if(remainderCounts.ContainsKey(remainder)){
                count += remainderCounts[remainder];
            }

            if(remainderCounts.ContainsKey(remainder)){
                remainderCounts[remainder]++;
            }
            else{
                remainderCounts[remainder] = 1;
            }
        }

        return count;
    }
}