public class Solution {
    public List<int> SpiralOrder(int[][] matrix) 
    {
        List<int> res = new List<int>();

        int left = 0, right = matrix[0].Length;
        int top = 0, bottom = matrix.Length;

        while(left < right && top < bottom){
            //from left to right
            for(int i = left; i < right; i++){
                res.Add(matrix[top][i]);
            }
            top++;
            //from top to bottom
            for(int i = top; i < bottom; i++ ){
                res.Add(matrix[i][right-1]);
            }
            right--;
            if(!(left<right && top<bottom)){
                break;
            }
            //from right to left
            for(int i = right - 1; i >= left; i--){
                res.Add(matrix[bottom-1][i]);
            }
            bottom--;
            //bottom to top
            for(int i = bottom - 1; i >= top; i--){
                res.Add(matrix[i][left]);
            }
            left++;
        }

        return res;
    }
    public List<int> SpiralOrder2(int[][] matrix) 
    {
        List<int> res = new List<int>();

        //Total to cover
        int rows = matrix.Length, cols = matrix[0].Length;
        //current position
        int currentRow = 0, currentCol = -1;
        //direction to travel
        int dirRow = 0, dirCol = 1;

        Dfs(rows, cols, currentRow, currentCol, dirRow, dirCol, matrix, res);

        return res;
    }

    void Dfs(int rows, int cols,
             int currentRow, int currentCol,
             int dirRow, int dirCol,
             int[][] matrix, List<int> res){
                if(rows == 0 || cols == 0){
                    return;
                }

                for(int i = 0; i < cols; i++ ){
                    currentRow += dirRow;
                    currentCol += dirCol;
                    res.Add(matrix[currentRow][currentCol]);
                }

                Dfs(cols, rows - 1, currentRow, currentCol, dirCol, -dirRow, matrix, res);
    }
}
