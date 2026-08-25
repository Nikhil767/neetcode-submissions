public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        if(nums is null || nums.Length < 3) return result;        
        Array.Sort(nums);
        int n = nums.Length;
        for (int i = 0; i < n - 2; i++)
        {
            // Skip duplicate first elements
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = n - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add(new List<int> { nums[i], nums[left], nums[right] });
                    // Move left and skip duplicates
                    int leftVal = nums[left];
                    while (left < right && nums[left] == leftVal)
                        left++;

                    // Move right and skip duplicates
                    int rightVal = nums[right];
                    while (left < right && nums[right] == rightVal)
                        right--;
                }
                else if (sum < 0)                
                    left++;                
                else                
                    right--;                
            }
        }
        return result;
    }
}
