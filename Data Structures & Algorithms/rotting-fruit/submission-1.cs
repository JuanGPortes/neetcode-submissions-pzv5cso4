public class Solution {

    public int OrangesRotting(int[][] grid) {

        if(grid.Length <= 0|| grid == null){
            return -1;
        }

        Queue<(int,int)> q = new Queue<(int,int)>();

        int fresh = 0, time = 0;

        for(int row = 0; row < grid.Length; row++){
            for(int col = 0; col < grid[0].Length; col++){
                if(grid[row][col] == 1){
                    fresh++;
                }
                if(grid[row][col] == 2){
                    q.Enqueue((row,col));
                }
            }
        }

        int[] dirRows = new int[] {-1,1,0,0};
        int[] dirCols = new int[] {0,0,1,-1};

        while(fresh > 0 && q.Count > 0){

            int length = q.Count;
            for(int i = 0; i < length; i++){
                var (cR, cC) = q.Dequeue();
                int r = cR, c = cC;

                for(int dir = 0; dir < 4; dir++){
                    int nr = r + dirRows[dir], nc = c + dirCols[dir];

                    if(
                        nr >= 0 && nr < grid.Length &&
                        nc >= 0 && nc < grid[0].Length &&
                        grid[nr][nc] == 1
                    ){
                        grid[nr][nc] = 2;
                        q.Enqueue((nr,nc));
                        fresh--;
                    }
                }
            }
            time++;
        }

        return fresh == 0 ? time : -1;

    }
}
