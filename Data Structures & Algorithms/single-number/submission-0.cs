public class Solution {
    public int SingleNumber(int[] nums) {
        if(nums is null || nums.Length < 1) return 0;
        int result = 0;
        foreach (var num in nums)
        {
            result ^= num;
        }
        return result;
    }
}
