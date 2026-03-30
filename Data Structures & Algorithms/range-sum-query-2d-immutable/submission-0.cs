public class NumMatrix {

    int[][] _matrix;

    public NumMatrix(int[][] matrix) {
        _matrix = matrix;
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int sum = 0;
        for(int row = row1; row <= row2; row++){
            for(int col = col1; col <= col2; col++){
                sum += _matrix[row][col];
            }
        }
        return sum;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */