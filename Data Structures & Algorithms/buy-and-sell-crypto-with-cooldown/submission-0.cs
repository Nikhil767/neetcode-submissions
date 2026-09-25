public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
        return 0;

    int n = prices.Length;

    int hold = -prices[0];   // Max profit when holding a coin
    int sold = 0;            // Max profit when just sold today
    int rest = 0;            // Max profit when in cooldown or idle

    for (int i = 1; i < n; i++)
    {
        int prevHold = hold;
        int prevSold = sold;
        int prevRest = rest;

        // If we hold today: either we already held, or we buy today (from rest state)
        hold = Math.Max(prevHold, prevRest - prices[i]);

        // If we sell today: must have held yesterday
        sold = prevHold + prices[i];

        // If we rest today: either we were already resting, or we just sold yesterday
        rest = Math.Max(prevRest, prevSold);
    }

    // Final answer is max of sold or rest (holding means unsold)
    return Math.Max(sold, rest);
    }
}
