public class Solution {
    readonly int[][] directions = new int[][] 
    {
        new int[] {0,-1},
        new int[] {0,1},
        new int[] {-1,0},
        new int[] {1,0}
    };
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length <= 0){
            return 0;
        }   

        int rows = grid.Length, cols = grid[0].Length;
        int islands = 0;

        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
                if(grid[r][c] == '1'){
                    Bfs(grid, r, c);
                    islands++;
                }
            }
        }

        return islands;
    }

    void Bfs(char[][] grid, int row, int col){
        Queue<int[]> q = new Queue<int[]>();
        grid[row][col] = '0';
        q.Enqueue(new int[]{row, col});

        while(q.Count > 0){
            var node = q.Dequeue();
            int r = node[0], c = node[1];
            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];
                if(nr >= 0 && nc >= 0 &&
                   nr < grid.Length && nc < grid[0].Length &&
                   grid[nr][nc] == '1'){
                    grid[nr][nc] = '0';
                    q.Enqueue(new int[]{nr, nc});
                }
            }
        }
    }
}
