public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        if (nums is null || nums.Length < 1) return 0;
        PriorityQueue<int, int> minHeap = new(k);
        foreach (var item in nums)
        {
            if (minHeap.Count == k)
            {
                if (minHeap.Peek() < item)
                    minHeap.DequeueEnqueue(item, item);					
            }
            else
                minHeap.Enqueue(item, item);
        }
        var kth = minHeap.Peek();
        return kth;
    }
}
