public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums is null || nums.Length < 1) return null;
        int n = nums.Length;
        int[] result = new int[n];

        int product = 1;
        result[0] = 1;
        for (int i=1; i<n; i++)
        {
            result[i] = result[i-1] * nums[i-1];
        }

        int suffix = 1;
        for (int j=n-1; j>=0; j--)
        {
            result[j] = result[j] * suffix;
            suffix = suffix* nums[j];
        }
        return result;
    }
}
