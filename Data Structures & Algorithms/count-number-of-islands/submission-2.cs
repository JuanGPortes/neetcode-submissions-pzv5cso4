public class Solution {

    readonly int[][] directions = new int[][]
    {
        //Down
        new int[] {1,0},
        //up
        new int[] {-1,0},
        //left
        new int[] {0,-1},
        //right
        new int[] {0,1}
    };
    
    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length <= 0 || grid.Length > 100){
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
        q.Enqueue(new int[]{row, col});
        grid[row][col] = '0';

        while(q.Count > 0){
            var node = q.Dequeue();
            int r = node[0], c = node[1];

            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];

                // if(nr >= 0 && nc >=0 &&
                //    nr < grid.Length && nc < grid[0].Length &&
                //    grid[nr][nc] == '1'){
                //     q.Enqueue(new int[]{nr, nc});
                //     grid[nr][nc] = '0';
                // }

                if(nr < 0 || nc < 0 || nr >= grid.Length || nc >= grid[0].Length || grid[nr][nc] == '0'){
                    continue;
                }
                else{
                    q.Enqueue(new int[]{nr, nc});
                    grid[nr][nc] = '0';
                }
            }
        }
    }

    void Dfs(char[][] grid, int row, int col){
        // if(row < 0 || col < 0 || row >= grid.Length || col >= grid[0].Length || grid[row][col] == '0'){
        //     return;
        // }

        // grid[row][col] = '0';

        // foreach(var dir in directions){
        //     Dfs(grid, row + dir[0], col + dir[1]);
        // }

        if(row >= 0 && col >=0 &&
                   row < grid.Length && col < grid[0].Length &&
                   grid[row][col] == '1'){
                    grid[row][col] = '0';
                    foreach(var dir in directions){
                        Dfs(grid, row + dir[0], col + dir[1]);
                    }
                }
                else{
                    return;
                }
    }
}
