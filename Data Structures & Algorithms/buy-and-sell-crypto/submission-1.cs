public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices is null || prices.Length < 1) return 0;

        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i=0; i<prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            int profit = prices[i] - minPrice;
            if (profit > maxProfit)
                maxProfit = profit;
        }
        return maxProfit;
    }
}
