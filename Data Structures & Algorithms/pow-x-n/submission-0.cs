public class Solution {
    public double MyPow(double x, int n) {
        // Use long to prevent integer overflow when n = int.MinValue (-2147483648)
        long N = n;
        // Handle negative exponents: x^(-N) = (1/x)^N
        if (N < 0)
        {
            x = 1 / x;
            N = -N;
        }
        double result = 1.0;
        double currentProduct = x;
        while (N > 0)
        {
            // If N is odd, multiply the current power into the result
            if ((N % 2) == 1)
            {
                result *= currentProduct;
            }
            // Square the base and halve the exponent
            currentProduct *= currentProduct;
            N /= 2;
        }
        return result;
    }
}
