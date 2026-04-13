public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        if(arr == null || arr.Length < 1){
            return 0;
        }

        if(arr.Length < 2){
            return 1;
        }

        int up = 1;
        int down = 1;
        int maxLength = 1;

        for(int i = 1; i < arr.Length; i++){
            if(arr[i] > arr[i - 1]){
                up = down + 1;
                down = 1;
            }
            else if(arr[i] < arr[i - 1]){
                down = up + 1;
                up = 1;
            }
            else{
                up = 1;
                down = 1;
            }

            maxLength = Math.Max(maxLength, Math.Max(up, down));
        }

        return maxLength;
    }
}