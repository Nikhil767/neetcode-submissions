public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums is null || nums.Length<1) return null;
        int[] result = new int[2];
        Dictionary<int, int> freq=new(nums.Length);
        for (int i=0; i<nums.Length; i++)
        {
            var diff = target-nums[i];
            if(freq.TryGetValue(diff, out int index))
            {
                result[0]=index;
                result[1]=i;
                return result;
            }
            else
                freq.Add(nums[i], i);
        }
        return result;
    }
}
