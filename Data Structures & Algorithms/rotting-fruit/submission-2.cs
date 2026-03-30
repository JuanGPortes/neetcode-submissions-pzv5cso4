public class Solution {

    public int OrangesRotting(int[][] grid) {

        if(grid == null || grid.Length < 1){
            return -1;
        }

        Queue<(int, int)> q = new Queue<(int, int)>();

        int time = 0, fresh = 0;

        for(int rows = 0; rows < grid.Length; rows++){
            for(int cols = 0; cols < grid[0].Length; cols++){
                if(grid[rows][cols] == 1){
                    fresh++;
                }
                if(grid[rows][cols] == 2){
                    q.Enqueue((rows, cols));
                }
            }
        }

        int[][] directions = new int[][] {
            [1, 0],
            [-1,0],
            [0, -1],
            [0, 1]
        };

        while(fresh > 0 && q.Count > 0){
            int length = q.Count;
            for(int i = 0; i < length; i++){
                var (row, col) = q.Dequeue();
                foreach(var dir in directions){
                    int nr = row + dir[0], nc = col + dir[1];
                    if(nr >= 0 && nr < grid.Length &&
                       nc >= 0 && nc < grid[0].Length &&
                       grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        fresh--;
                        q.Enqueue((nr, nc));
                    }
                }
            }
            time++;
        }
        return fresh == 0 ? time : -1;
    }
}
