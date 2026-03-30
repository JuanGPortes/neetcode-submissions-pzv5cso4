public class Solution {
    public int MaxArea(int[] heights) {
        if(heights == null || heights.Length < 2){
            return 0;
        }

        int maxArea = 0;

        int left = 0;
        int right = heights.Length - 1;

        while(left < right)
        {
            int width = right - left;
            int height = heights[left] < heights[right] ? heights[left] : heights[right];

            int currentArea = width * height;

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
