public class Solution {
    readonly int[][] directions = new int[][]{
        new int[] {-1,0},
        new int[] {1,0},
        new int[] {0,1},
        new int[] {0,-1}
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
                    Dfs(grid, r, c);
                    islands++;
                }
            }
        }
        return islands;
    }

    public void Dfs(char[][] grid, int r, int c){
        if(
            r < 0
            || c < 0
            || r >= grid.Length
            || c >= grid[0].Length
            || grid[r][c] == '0'
        ){
            return;
        }

        grid[r][c] = '0';

        foreach(var dir in directions){
            Dfs(grid, r + dir[0], c + dir[1]);
        }
    }

}
