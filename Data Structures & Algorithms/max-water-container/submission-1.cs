public class Solution {
    public int MaxArea(int[] heights) {
        if(heights == null || heights.Length < 2){
            return 0;
        }

        int maxArea = 0;

        for(int i = 0; i < heights.Length; i++){
            for(int j = i + 1; j < heights.Length; j++){
                int area = (j - i) * (heights[i] < heights[j] ? heights[i] : heights[j]);

                if(area > maxArea){
                    maxArea = area;
                }
            }
        }

        return maxArea;
    }
}
