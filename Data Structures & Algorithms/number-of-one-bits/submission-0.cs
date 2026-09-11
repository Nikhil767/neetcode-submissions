public class Solution {
    public int HammingWeight(uint n) {
        int result = 0;
        while (n != 0)
        {
            n = n & (n - 1); // Clears the lowest set bit
            result++;
        }
        return result;
    }
}
