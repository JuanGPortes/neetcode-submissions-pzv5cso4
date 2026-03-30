public class Solution {

    public int OrangesRotting(int[][] grid) {

        int[][] directions = new int[][]{
            new int[] {-1,0},
            new int[] {1,0},
            new int[] {0,1},
            new int[] {0,-1}
        };

        if(grid == null || grid.Length <= 0){
            return -1;
        }

        Queue<int[]> q = new Queue<int[]>(); //will store the rotten ruit positions
        int timeElapsed = 0, freshCount = 0;

        for(int r = 0; r < grid.Length; r++){
            for(int c = 0; c < grid[0].Length; c++){
                if(grid[r][c] == 1){
                    freshCount++;
                }
                if(grid[r][c] == 2){
                    q.Enqueue(new int[] {r, c});
                }
            }
        }

        while(freshCount > 0 && q.Count > 0){
            int rottenCount = q.Count;
            for(int i = 1; i <= rottenCount; i++){
                int[] currentRottenPos = q.Dequeue();
                int r = currentRottenPos[0];
                int c = currentRottenPos[1];

                foreach(var dir in directions){
                    int nr = r + dir[0];
                    int nc = c + dir[1];

                    if(nr >= 0 && nr < grid.Length &&
                       nc >= 0 && nc < grid[0].Length &&
                       grid[nr][nc] == 1){
                        grid[nr][nc] = 2;
                        freshCount--;
                        q.Enqueue(new int[] {nr, nc});
                    }
                }
            }
            timeElapsed++;
        }

        return freshCount == 0 ? timeElapsed : -1;
    }
}
