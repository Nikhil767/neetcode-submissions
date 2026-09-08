public class KthLargest {
    int kMax = 0;
    PriorityQueue<int, int> maxHeap = null;
    public KthLargest(int k, int[] nums) {
        kMax = k;
        maxHeap = new(k);
        foreach (var i in nums)
        {
            if (maxHeap.Count == k)
            {
                if (maxHeap.Peek() < i)
                    maxHeap.DequeueEnqueue(i, i);					
            }
            else
				maxHeap.Enqueue(i, i);
        }        
    }
    
    public int Add(int val) {
        maxHeap.Enqueue(val, val);
        if (maxHeap.Count > kMax)
            maxHeap.Dequeue();   // remove smallest
        return maxHeap.Peek();   // kth largest
    }
}
