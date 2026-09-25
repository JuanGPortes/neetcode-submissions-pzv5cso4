public class Solution {
    public int ClimbStairs(int n) {     
        int[] memo = new int[n + 1];

        return DFS(n, memo);
    }

    private int DFS(int n, int[] memo){
        if(n <= 2){
            return n;
        }

        if(memo[n] != 0){
            return memo[n];
        }

        memo[n] = DFS(n - 1, memo) + DFS(n - 2, memo);


        return memo[n];
    }
}
