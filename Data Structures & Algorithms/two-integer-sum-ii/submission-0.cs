public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if(numbers is null || numbers.Length < 1) return null;
        int[] result = new int[2];
        int right=numbers.Length-1;
        int left=0;
        int index=0;
        while(left < right)
        {
            var sum = numbers[left] + numbers[right];
            if(sum == target)
            {
                result[0] = left+1;
                result[1] = right+1;
                return result;
            }
            else if (sum < target)
                left++;
            else
                right--;
        }
        return result;
    }
}
