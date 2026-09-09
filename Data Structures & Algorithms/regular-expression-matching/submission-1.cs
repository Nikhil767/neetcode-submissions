public class Solution {
    public bool IsMatch(string s, string p) {
        //return Match(s,p,0,0);

        int n = s.Length;
        int m = p.Length;

        bool[,] dp = new bool[n + 1, m + 1];
        dp[0, 0] = true;

        // Handle patterns like a*, a*b*, a*b*c*
        for (int j = 1; j < m; j++)
        {
            if (p[j] == '*' && dp[0, j - 1])
                dp[0, j + 1] = true;
        }

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= m; j++)
            {
                if (p[j - 1] == '.' || p[j - 1] == s[i - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1];
                }
                else if (p[j - 1] == '*')
                {
                    // Zero occurrences of previous char
                    dp[i, j] = dp[i, j - 2];

                    // One or more occurrences
                    if (p[j - 2] == '.' || p[j - 2] == s[i - 1])
                        dp[i, j] |= dp[i - 1, j];
                }
            }
        }

        return dp[n, m];
    }

    private bool Match(string s, string p, int i, int j)
    {
        // If pattern is finished, string must also be finished
        if (j == p.Length)
            return i == s.Length;

        // Check if current characters match
        bool currentMatch = (i < s.Length &&
                            (s[i] == p[j] || p[j] == '.'));

        // If next pattern char is '*', we have two choices:
        // 1. Skip the "x*" entirely
        // 2. Use the '*' to match current character (if possible)
        if (j + 1 < p.Length && p[j + 1] == '*')
        {
            return Match(s, p, i, j + 2) ||       // skip "x*"
                   (currentMatch && Match(s, p, i + 1, j)); // use "*"
        }

        // Normal character match
        if (currentMatch)
            return Match(s, p, i + 1, j + 1);

        return false;
    }
}
