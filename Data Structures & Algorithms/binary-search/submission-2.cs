public class Solution {
    public int Search(int[] nums, int target) {
        int index = -1;
        if (nums is null || nums.Length < 1) return index;        
        int low = 0;
        int high = nums.Length-1;
        while (low <= high)
        {
            //var mid = low + (high-low)/2;
            var mid = low + ((high-low) >> 1); // bitwise divide by 2
            if(nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                high = mid-1;
            else
                low = mid+1;
        }
        return index;
    }
}
