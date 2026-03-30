public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {

        List<int> res = new List<int>();

        int rows = matrix.Length, cols = matrix[0].Length;
        int rowPos = 0, colPos = -1;
        int rowDir = 0, colDir = 1;

        Dfs(rows, cols, rowPos, colPos, rowDir, colDir, matrix, res);

        return res;
        
    }

    private void Dfs(int rows, int cols,
                    int rowPos, int colPos,
                    int rowDir, int colDir,
                    int[][] matrix, List<int> res)
    {
        if(rows <=0 || cols <= 0){
            return;
        }

        for(int i = 0; i < cols; i++){
            rowPos += rowDir;
            colPos += colDir;
            res.Add(matrix[rowPos][colPos]);
        }

        Dfs(cols, rows - 1,
            rowPos, colPos,
            colDir, -rowDir,
            matrix, res);
    }
}
