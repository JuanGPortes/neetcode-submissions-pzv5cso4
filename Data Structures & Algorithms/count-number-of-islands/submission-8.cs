public class Solution {
    private readonly int[][] directions = new int[][]{
        new int[] { 0, 1 },
        new int[] { 1, 0 },
        new int[] { 0, -1 },
        new int[] { -1, 0 }
    };

    public int NumIslands(char[][] grid) {
        if(grid == null || grid.Length < 1){
            return 0;
        }

        int rows = grid.Length;
        int cols = grid[0].Length;
        int islands = 0;

        for(int row = 0; row < rows; row++){
            for(int col = 0; col < cols; col++){
                if(grid[row][col] == '1'){
                    Bfs(row, col, grid);
                    islands++;
                }
            }
        }
        
        return islands;
    }

    private void Bfs(int row, int col, char[][] grid){
        Queue<int[]> queue = new Queue<int[]>();
        queue.Enqueue(new int[] { row, col });
        grid[row][col] = '0';

        int rows = grid.Length;
        int cols = grid[0].Length;

        while(queue.Count > 0){
            var node = queue.Dequeue();
            int nodeRow = node[0];
            int nodeCol = node[1];
            foreach(var dir in directions){
                int newRow = nodeRow + dir[0];
                int newCol = nodeCol + dir[1];
                if(newRow >= 0 && newRow < rows &&
                   newCol >= 0 && newCol < cols &&
                   grid[newRow][newCol] == '1'){
                    queue.Enqueue(new int[] { newRow, newCol });
                    grid[newRow][newCol] = '0';
                }
            }
        }
    }
}
