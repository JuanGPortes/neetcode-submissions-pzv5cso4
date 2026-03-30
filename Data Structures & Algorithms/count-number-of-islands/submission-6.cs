public class Solution {

    private static readonly (int, int)[] directions = new (int, int)[]{
        (-1, 0),
        (0, 1),
        (1, 0),
        (0, -1)
    };

    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length < 1){
            return 0;
        }

        int m = grid.Length, n = grid[0].Length;
        int islands = 0;

        for(int r = 0; r < m; r++){
            for(int c = 0; c < n; c++){
                if(grid[r][c] == '1'){
                    Bfs(r, c, grid);
                    islands++;
                }
            }
        }

        return islands;
    }

    void Bfs(int row, int col, char[][] grid){
        int m = grid.Length, n = grid[0].Length;
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((row, col));
        grid[row][col] = '0';

        while(q.Count > 0){
            var (r, c) = q.Dequeue();
            foreach(var (dr, dc) in directions){
                int nr = r + dr;
                int nc = c + dc;
                if(nr >= 0 && nr < m &&
                   nc >= 0 && nc < n &&
                   grid[nr][nc] == '1'){
                    grid[nr][nc] = '0';
                    q.Enqueue((nr, nc));
                }
            }
        }
    }
}
