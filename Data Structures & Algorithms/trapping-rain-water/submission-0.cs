public class Solution {
    public int Trap(int[] height) {
        if(height == null || height.Length < 3){
            return 0;
        }

        int totalWater = 0;
        int len = height.Length;

        for(int i = 1; i < len - 1; i++){
            int maxLeft = 0;
            int maxRight = 0;

            for(int L = i; L >= 0; L--){
                maxLeft = Math.Max(maxLeft, height[L]);
            }

            for(int R = i; R < len; R++){
                maxRight = Math.Max(maxRight, height[R]);
            }

            totalWater += Math.Min(maxLeft, maxRight) - height[i];
        }

        return totalWater;
    }
}
