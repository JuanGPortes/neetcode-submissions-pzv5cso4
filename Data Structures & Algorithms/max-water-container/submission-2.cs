public class Solution {
    public int MaxArea(int[] heights) {
        if(heights == null || heights.Length < 2){
            return 0;
        }

        int len = heights.Length;
        int left = 0;
        int right = heights.Length - 1;
        int maxArea = 0;

        while(left < right){
            int height = heights[left] < heights[right] ? heights[left] : heights[right];
            int width = right - left; 
            int currentArea = height * width;

            if(currentArea > maxArea){
                maxArea = currentArea;
            }

            if(heights[left] < heights[right]){
                left++;
            }
            else{
                right--;
            }
        }

        return maxArea;
    }
}
