public class Solution {
    int [][] directions = new int[][] {
        new int[] {1,0},
        new int[] {-1,0},
        new int[] {0,-1},
        new int[] {0,1}
    };
    public int NumIslands(char[][] grid) {
        if(grid.Length <= 0 || grid == null){
            return 0;
        }

        int rows = grid.Length, cols = grid[0].Length;
        int islands = 0;

        for(int r = 0; r < rows; r++){
            for(int c = 0; c < cols; c++){
                if(grid[r][c] == '1'){
                    DfsQ(grid, r, c);
                    islands++;
                }
            }
        }

        return islands;
        
    }

    void Dfs(char[][] grid, int row, int col){
        
            if(row < 0 || row >= grid.Length ||
               col < 0 || col >= grid[0].Length ||
               grid[row][col] == '0'){
                return;
            }

            grid[row][col] = '0';
        foreach(var dir in directions){
            int nr = row + dir[0], nc = col + dir[1];

            Dfs(grid, nr, nc);
        }
    }

    void DfsQ(char[][] grid, int row, int col){
        Stack<int[]> s = new Stack<int[]>();
        grid[row][col] = '0';
        s.Push(new int[] {row,col});
        while(s.Count > 0){
            var node = s.Pop();
            int r = node[0], c = node[1];
            
            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];
                if(nr >= 0 && nr < grid.Length &&
                   nc >= 0 && nc < grid[0].Length &&
                   grid[nr][nc] == '1'){
                    grid[nr][nc] = '0';
                    s.Push(new int[]{nr,nc});
                    
                }
            }
        }
    }

    void Bfs(char[][] grid, int row, int col){
        Queue<int[]> q = new Queue<int[]>();
        q.Enqueue(new int[]{row,col});

        while(q.Count > 0){
            var node = q.Dequeue();
            int r = node[0], c = node[1];
            grid[r][c] = '0';
            foreach(var dir in directions){
                int nr = r + dir[0], nc = c + dir[1];
                if(nr >= 0 && nr < grid.Length &&
                    nc >= 0 && nc < grid[0].Length &&
                    grid[nr][nc] == '1'){
                    q.Enqueue(new int[] {nr, nc});
                }
            }
        }
    }
}
