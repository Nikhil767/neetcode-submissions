public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var result = new List<int>();
        var deque = new LinkedList<int>(); // stores indices

        for (int i = 0; i < nums.Length; i++)
        {
            // Remove indices that are out of this window
            if (deque.Count > 0 && deque.First.Value <= i - k)
                deque.RemoveFirst();

            // Maintain decreasing order in deque
            while (deque.Count > 0 && nums[deque.Last.Value] < nums[i])
                deque.RemoveLast();

            deque.AddLast(i);

            // Window formed
            if (i >= k - 1)
                result.Add(nums[deque.First.Value]);
        }

        return result.ToArray();
    }
}
