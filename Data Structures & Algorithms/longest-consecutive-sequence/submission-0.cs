public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums is null || nums.Length < 1) return 0;
        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;
        foreach(var num in nums)
        {
            // Only start counting if this is the beginning of a sequence
            if (!set.Contains(num - 1))
            {
                int current = num;
                int length = 1;
                while (set.Contains(current + 1))
                {
                    current++;
                    length++;
                }
                longest = Math.Max(longest, length);
            }
        }
        return longest;
    }
}
