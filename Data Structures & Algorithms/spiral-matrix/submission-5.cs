public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {
        if(matrix ==  null || matrix.Length < 1){
            return new List<int>();
        }
        List<int> result = new List<int>();
        
        int[] steps = new int[]{
            matrix[0].Length,
            matrix.Length - 1
        };

        (int, int)[] directions = new (int, int)[] {
            (0, 1),
            (1, 0),
            (0, -1),
            (-1, 0)
        };

        int r = 0, c = -1;
        int d = 0;

        while(steps[d % 2] > 0){
            for(int i = 0; i < steps[d % 2]; i++){
                r += directions[d].Item1;
                c += directions[d].Item2;

                result.Add(matrix[r][c]);
            }
            steps[d % 2]--;

            d = (d + 1) % directions.Length;
        }
        

        return result;
    }
}
