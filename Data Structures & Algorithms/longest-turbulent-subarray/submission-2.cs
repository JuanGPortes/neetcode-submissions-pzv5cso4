public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        if(arr == null || arr.Length < 1){
            return 0;
        }

        if(arr.Length < 2){
            return 1;
        }

        int left = 0, right = 1;
        int maxLength = 1;
        int prevSign = 0; //0,1,-1

        while(right < arr.Length){
            if(arr[right - 1] > arr[right] && prevSign != -1){
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
                prevSign = -1;
            }
            else if(arr[right - 1] < arr[right] && prevSign != 1){
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
                prevSign = 1;
            }
            else{
                right = (arr[right - 1] == arr[right]) ? right + 1 : right;

                left = right - 1;

                prevSign = 0;
            }
        }

        return maxLength;
    }
}