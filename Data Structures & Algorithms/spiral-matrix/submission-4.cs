public class Solution {
    public List<int> SpiralOrder(int[][] matrix) 
    {
        bool doRecursion = false;
        List<int> res = new List<int>();
        
        if(doRecursion){
            Recursion(matrix, res);
        }
        else{
            IterationOptimal(matrix, res);
        }

        return res;
    }

    void Recursion(int[][] matrix, List<int> res){

        //Total rows and cols to traverse
        int rows = matrix.Length, cols = matrix[0].Length;
        //Start position (current position)
        int currentRow = 0, currentCol = -1;
        //Direction
        int directionRow = 0, directionCol = 1;

        Dfs(rows, cols, currentRow, currentCol, directionRow, directionCol, matrix, res);

    }

    void Dfs(int rows, int cols, 
             int currentRow, int currentCol, 
             int directionRow, int directionCol, 
             int[][] matrix, List<int> res)
    {
        if(rows == 0 || cols == 0){
            return;
        }        

        for(int i = 1; i <= cols; i++){
            currentRow += directionRow;
            currentCol += directionCol;
            res.Add(matrix[currentRow][currentCol]);
        }
        Dfs(cols, rows - 1, currentRow, currentCol, directionCol, -directionRow, matrix, res);
    }

    void Iteration(int[][] matrix, List<int> res){
        int left = 0, right = matrix[0].Length;
        int top = 0, bottom = matrix.Length;

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
    }

    void IterationOptimal(int[][] matrix, List<int> res){
        int[] steps = new int[] 
        { 
            matrix[0].Length, //column horizontal traverse
            matrix.Length - 1//row vertical traverse
        };

        //Directions to traverse the matrix in spiral order
        var directions = new (int, int)[] 
        {
            (0, 1),
            (1, 0),
            (0, -1),
            (-1, 0)
        };

        //variables for an direction index and the starting cell
        int row = 0, col = -1, d = 0;

        while(steps[d % 2] > 0){
            for(int i = 0; i < steps[d % 2]; i++){
                row += directions[d].Item1;
                col += directions[d].Item2;
                res.Add(matrix[row][col]);
            }
            steps[d % 2]--;
            d = (d + 1) % 4;
        }
    }
}
