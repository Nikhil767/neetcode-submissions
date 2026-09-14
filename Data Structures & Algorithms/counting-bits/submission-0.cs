public class Solution {
    public int[] CountBits(int n) {
        // Create an array to store the number of 1-bits for each number from 0 to n
        int[] result = new int[n + 1];

        // Start from 1 because result[0] is already 0 (binary 0 has zero 1s)
        for (int i = 1; i <= n; i++)
        {
            // Step 1: Divide the number by 2 using right shift (i >> 1)
            // This removes the last bit.
            int half = i >> 1;

            // Step 2: Check the last bit using (i & 1)
            // If the last bit is 1, this adds 1; otherwise adds 0.
            int lastBit = i & 1;

            // Step 3: Total bits = bits in half + lastBit
            result[i] = result[half] + lastBit;
        }

        return result;
    }
}
