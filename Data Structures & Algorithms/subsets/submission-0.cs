public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        Backtrack(0, new List<int>(), nums, result);
        return result;
    }

    private void Backtrack(int index, List<int> current, int[] nums, List<List<int>> result)
    {
        result.Add(new List<int>(current));
        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);
            Backtrack(i + 1, current, nums, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}
