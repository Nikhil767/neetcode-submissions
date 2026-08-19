public class Solution {
    public bool hasDuplicate(int[] nums) {
        if (nums is null || nums.Length < 1) return false;
        if(nums.Length == 1) return false;
        HashSet<int> freq = new(nums.Length);
        foreach(int i in nums)
        {
            if(!freq.Contains(i))
                freq.Add(i);
            else
                return true;
        }
        return false;
    }
}