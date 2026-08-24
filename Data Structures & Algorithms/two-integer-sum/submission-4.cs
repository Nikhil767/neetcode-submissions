public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums is null || nums.Length<1) return null;
        Dictionary<int, int> freq=new(nums.Length);
        for (int i=0; i<nums.Length; i++)
        {
            var diff = target-nums[i];
            if(freq.TryGetValue(diff, out int index))            
                return [index, i];            
            else if(!freq.ContainsKey(nums[i]))
                freq.Add(nums[i], i);
        }
        return [];
    }
}
