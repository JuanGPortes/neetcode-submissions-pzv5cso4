public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices == null || prices.Length < 2){
            return 0;
        }

        int maxProfit = 0;
        int lowestPrice = prices[0];

        for(int i = 0; i < prices.Length; i++){
            int currentPrice = prices[i];

            if(currentPrice < lowestPrice){
                lowestPrice = currentPrice;
            }
            else{
                int currentProfit = currentPrice - lowestPrice;
                if(currentProfit > maxProfit){
                    maxProfit = currentProfit;
                }
            }
        }

        return maxProfit;
    }
}
