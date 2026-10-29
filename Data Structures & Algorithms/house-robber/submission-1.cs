public class Solution {
    public int Rob(int[] nums) {
         int prev2 = 0; // dp[i - 2]
        int prev1 = 0; // dp[i - 1]

        foreach (int money in nums)
        {
            int current = Math.Max(prev1, prev2 + money);

            prev2 = prev1;
            prev1 = current;
        }

        return prev1;
    }
}
