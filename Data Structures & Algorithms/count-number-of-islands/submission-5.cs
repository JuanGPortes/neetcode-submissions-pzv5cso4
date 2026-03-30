public class Solution {

    readonly int[][] directions = new int[][] {
        new int[] {1, 0},
        new int[] {-1, 0},
        new int[] {0, 1},
        new int[] {0, -1}
    };

    public int NumIslands(char[][] grid) {
        
        if(grid == null || grid.Length < 1) return 0;

        int islands = 0;

        for(int rows = 0; rows < grid.Length; rows++){
            for(int cols = 0; cols < grid[0].Length; cols++){
                if(grid[rows][cols] == '1'){
                    Bfs(rows, cols, grid);
                    islands++;
                }
            }
        }

        return islands;
    }

    private void Dfs(int row, int col, char[][] grid){
        if(row >= 0 && row < grid.Length &&
            col >= 0 && col < grid[0].Length &&
            grid[row][col] == '1'){
                grid[row][col] = '0';
                foreach(var dir in directions){
                    int nr = row + dir[0], nc = col + dir[1];
                    Dfs(nr, nc, grid);
                }
        }
    }

    private void DfsS(int row, int col, char[][] grid){
        Stack<(int, int)> s = new Stack<(int, int)>();
        grid[row][col] = '0';
        s.Push((row, col));

        while(s.Count > 0){
            var (r, c) = s.Pop();
            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];
                if(nr >= 0 && nc >= 0 && nr < grid.Length && nc < grid[0].Length &&
                    grid[nr][nc] == '1'){
                        grid[nr][nc] = '0';
                        s.Push((nr, nc));
                }
            }
        }
    }

    private void Bfs(int row, int col, char[][] grid){
        Queue<(int, int)> s = new Queue<(int, int)>();
        grid[row][col] = '0';
        s.Enqueue((row, col));

        while(s.Count > 0){
            var (r, c) = s.Dequeue();
            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];
                if(nr >= 0 && nc >= 0 && nr < grid.Length && nc < grid[0].Length &&
                    grid[nr][nc] == '1'){
                        grid[nr][nc] = '0';
                        s.Enqueue((nr, nc));
                }
            }
        }
    }
}
