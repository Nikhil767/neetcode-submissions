public class Solution {
    public int Change(int amount, int[] coins) {
        int[] dp = new int[amount + 1];
        dp[0] = 1;

        foreach (int coin in coins)
        {
            for (int currAmount = coin; currAmount <= amount; currAmount++)
            {
                dp[currAmount] += dp[currAmount - coin];
            }
        }

        return dp[amount];  
    }
}
