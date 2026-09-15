public class Solution {
    public bool IsHappy(int n) {
        if (n < 0) return false;
        if (n == 1) return true;

        HashSet<int> seen = new();        
        while (n > 0 && n != 1)
        {
            int sum = GetSum(n);
            if(sum == 1)
                return true;
            if(seen.Contains(sum))
                return false;
            seen.Add(sum);
            n = sum;
        }
        return false;
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
