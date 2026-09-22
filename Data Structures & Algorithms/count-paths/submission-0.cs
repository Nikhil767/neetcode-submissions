public class Solution {
    public int UniquePaths(int m, int n) {
        long result = 1;
        int total = m + n - 2;
        int k = Math.Min(m - 1, n - 1);

        for (int i = 1; i <= k; i++)
        {
            result = result * (total - (k - i)) / i;
        }

        return (int)result;
    }
}
