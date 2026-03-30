public class Solution {
    public List<int> SpiralOrder(int[][] matrix) {

        int m = matrix.Length;
        int n = matrix[0].Length;

        List<int> res = new List<int>();

        int rp = 0;
        int cp = -1;
        int rd = 0;
        int cd = 1;

        Dfs(m, n, rp, cp, rd, cd, matrix, res);

        return res;
        
    }

    void Dfs(int m, int n, 
    int rp, int cp, 
    int rd, int cd, 
    int[][] matrix, List<int> res){

        if(m == 0 || n == 0){
            return;
        }

        for(int i = 0; i < n; i++){
            rp += rd;
            cp += cd;
            res.Add(matrix[rp][cp]);
        }

        Dfs(n, m-1, rp, cp, cd, -rd ,matrix, res);

    }
}
