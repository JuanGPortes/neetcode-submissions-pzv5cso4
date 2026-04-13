public class Solution {
    public int MaxTurbulenceSize(int[] arr) {
        if(arr == null || arr.Length < 1){
            return 0;
        }

        if(arr.Length < 2){
            return 1;
        }

        int len = arr.Length;
        int maxLength = 1;

        for(int i = 0; i < len - 1; i++){
            if(arr[i] == arr[i + 1]){
                continue;
            }

            int j = i + 1;

            int lastSign = arr[i] > arr[j] ? 1 : -1;

            while(j < len - 1){
                if(arr[j] == arr[j + 1]){
                    break;
                }


                int currSign = arr[j] > arr[j + 1] ? 1 : -1;

                if(lastSign == currSign){
                    break;
                }

                lastSign = currSign;

                j++;
            }

            maxLength = Math.Max(maxLength, j - i + 1);
        }
        return maxLength;
    }
}