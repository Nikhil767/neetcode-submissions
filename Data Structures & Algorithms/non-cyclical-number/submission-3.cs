public class Solution {
    public bool IsHappy(int n) {
        if (n < 0) return false;
        if (n == 1) return true;

        HashSet<int> seen = new();        
        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = GetSum(n);
        }
        return n == 1;
    }

    private int GetSum(int n)
    {
        int sum=0;
        while (n > 0)
        {
            int digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }
        return sum;
    }
}
