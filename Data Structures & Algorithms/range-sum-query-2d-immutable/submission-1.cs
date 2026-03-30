public class NumMatrix {

    int[][] _matrix;
    public NumMatrix(int[][] matrix) {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        _matrix = new int[rows + 1][];

        for(int row = 0; row <= rows; row++){
            _matrix[row] = new int[cols + 1];
        }

        for(int row = 0; row < rows; row++){
            for(int col = 0; col < cols; col++){
                _matrix[row + 1][col + 1] = matrix[row][col] +
                                            _matrix[row][col + 1] +
                                            _matrix[row + 1][col] -
                                            _matrix[row][col];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        int r1 = row1;
        int c1 = col1;
        int r2 = row2 + 1;
        int c2 = col2 + 1;

        int total = _matrix[r2][c2];
        int topResidue = _matrix[r1][c2];
        int leftResidue = _matrix[r2][c1];
        int doubleSubtractedResidue = _matrix[r1][c1];

        return total - topResidue - leftResidue + doubleSubtractedResidue;
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */