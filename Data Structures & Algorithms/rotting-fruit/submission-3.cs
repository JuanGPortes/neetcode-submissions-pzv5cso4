public class Solution {
    private static readonly (int, int)[] directions =
        new (int, int)[] {
            (-1, 0),//up
            (0, 1),//right
            (1, 0),//down
            (0, -1),//left
        };
    public int OrangesRotting(int[][] grid) {
        if(grid == null || grid.Length < 1){
            return -1;
        }

        int m = grid.Length;
        int n = grid[0].Length;

        for(int r = 0; r < m; r++){
            for(int c = 0; c < n; c++){
                if(grid[r][c] == 2){
                    DFS(r, c, grid, 2);
                }
            }
        }

        int maxTime = 0;

        for(int r = 0; r < m; r++){
            for(int c = 0; c < n; c++){
                if(grid[r][c] == 1){
                    return -1;
                }
                else if(grid[r][c] >= 2){
                    maxTime = Math.Max(maxTime, grid[r][c] - 2);
                }
            }
        }

        return maxTime;

    }

    void DFS(int row, int col, int[][] grid, int time){
        int m = grid.Length;
        int n = grid[0].Length;
        if(row < 0 || row >= m ||
           col < 0 || col >= n ||
           grid[row][col] == 0){
            return;
        }

        if(grid[row][col] != 1 && 
           grid[row][col] < time){
            return;
        }

        grid[row][col] = time;

        foreach((int dr, int dc) in directions){
            int nr = row + dr;
            int nc = col + dc;
            DFS(nr, nc, grid, time + 1);
        }        
    }
}
