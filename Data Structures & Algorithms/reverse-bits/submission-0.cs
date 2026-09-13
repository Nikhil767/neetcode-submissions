public class Solution {
    public uint ReverseBits(uint n) {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            result <<= 1;        // shift result left
            result |= (n & 1);   // add the last bit of n
            n >>= 1;             // shift n right
        }
        return result;
    }
}
