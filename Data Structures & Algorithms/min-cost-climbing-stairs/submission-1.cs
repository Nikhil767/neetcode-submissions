public class Solution {
    public int MinCostClimbingStairs(int[] cost) {

        int n = cost.Length;
        if (n == 1) return cost[0];

        int prev2 = cost[0]; // dp[i-2]
        int prev1 = cost[1]; // dp[i-1]

        for (int i = 2; i < n; i++)
        {
            int curr = Math.Min(prev1, prev2) + cost[i];
            prev2 = prev1;
            prev1 = curr;
        }

        return Math.Min(prev1, prev2);
    }
}
