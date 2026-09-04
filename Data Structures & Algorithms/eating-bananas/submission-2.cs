public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = piles.Max();
        int res = right;

        while(left <= right){
            long totalHours = 0;
            int k = left + (right - left) / 2;

            foreach(int pile in piles){
                totalHours += (long)Math.Ceiling((double)pile / k);
            }

            if(totalHours <= h){
                res = k;
                right = k - 1;
            }
            else{
                left = k + 1;
            }
        }
        return res;
    }
}
