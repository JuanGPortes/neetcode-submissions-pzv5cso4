public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        if(matrix == null || matrix.Length < 1){
            return new List<int>();
        }

        int left = 0, right = matrix[0].Length;
        int top = 0, bottom = matrix.Length;
        List<int> res = new List<int>();

        while(left < right && top < bottom){
            for(int i = left; i < right; i++){
                res.Add(matrix[top][i]);
            }
            top++;

            for(int i = top; i < bottom; i++){
                res.Add(matrix[i][right - 1]);
            }
            right--;

            if(!(left < right && top < bottom)){
                break;
            }

            for(int i = right - 1; i >= left; i--){
                res.Add(matrix[bottom - 1][i]);
            }
            bottom--;

            for(int i = bottom - 1; i >= top; i--){
                res.Add(matrix[i][left]);
            }
            left++;
        }

        return res;
    }
}
