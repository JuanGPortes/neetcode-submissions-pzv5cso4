public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        if(matrix == null || matrix.Length == 0){
            return false;
        }

        int m = matrix.Length;
        int n = matrix[0].Length;

        for(int row = 0; row < m; row++)
        {
            if(target <= matrix[row][n - 1]){
                int left = 0, right = n - 1, mid = 0;
                while(left <= right){
                    mid = left + (right - left) / 2;

                    if(target > matrix[row][mid]){
                        left = mid + 1;
                    }
                    else if(target < matrix[row][mid]){
                        right = mid - 1;
                    }
                    else{
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
