public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length < 2){
            return 0;
        }

        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while(right < prices.Length){
            if(prices[left] < prices[right]){
                maxProfit = Math.Max(maxProfit, prices[right] - prices[left]);
            }
            else{
                left = right;
            }

            right++;
        }

        return maxProfit;
    }
}
