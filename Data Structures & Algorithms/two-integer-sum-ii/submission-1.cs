public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers is null || numbers.Length < 1) return null;
        int right=numbers.Length-1;
        int left=0;
        while(left < right)
        {
            var sum = numbers[left] + numbers[right];
            if(sum == target)
            {
                return [left + 1, right + 1];
            }
            else if (sum < target)
                left++;
            else
                right--;
        }
        return [];
    }
}
