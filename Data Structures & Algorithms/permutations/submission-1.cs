public class Solution {
    public List<List<int>> Permute(int[] nums) {
        var result = new List<List<int>>();
        var path = new List<int>();
        var used = new bool[nums.Length];

        void Backtrack()
        {
            if (path.Count == nums.Length)
            {
                result.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i]) continue;

                used[i] = true;
                path.Add(nums[i]);

                Backtrack();

                path.RemoveAt(path.Count - 1);
                used[i] = false;
            }
        }

        Backtrack();
        return result;
    }
}
