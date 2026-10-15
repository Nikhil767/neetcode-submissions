public class Solution {
    public int MaxSubArray(int[] nums) {
        int current = nums[0];
        int max = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            // Either extend the current subarray or start a new one
            current = Math.Max(nums[i], current + nums[i]);

            // Track the global maximum
            max = Math.Max(max, current);
        }

        return max;
    }
}
