public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length < 3){
            return 0;
        }

        int totalWater = 0;
        int len = height.Length;

        int[] maxLeft = new int[len];
        int[] maxRight = new int[len];

        maxLeft[0] = height[0];
        for(int i = 1; i < len; i++){
            maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
        }

        maxRight[len - 1] = height[len - 1];
        for(int i = len - 2; i >= 0; i--){
            maxRight[i] = Math.Max(maxRight[i + 1], height[i]);
        }

        for(int i = 0; i < len; i++){
            totalWater += Math.Min(maxLeft[i], maxRight[i]) - height[i];
        }

        return totalWater;
    }
}
