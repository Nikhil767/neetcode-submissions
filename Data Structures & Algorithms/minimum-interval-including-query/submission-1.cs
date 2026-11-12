public class Solution {
    public int[] MinInterval(int[][] intervals, int[] queries) {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        int n = queries.Length;
        int[][] sortedQueries = new int[n][];

        for (int i = 0; i < n; i++)
            sortedQueries[i] = new int[] { queries[i], i };

        Array.Sort(sortedQueries, (a, b) => a[0].CompareTo(b[0]));

        int[] result = new int[n];
        PriorityQueue<(int size, int right), int> pq = new();

        int j = 0;

        foreach (var q in sortedQueries)
        {
            int query = q[0];
            int idx = q[1];

            while (j < intervals.Length && intervals[j][0] <= query)
            {
                int left = intervals[j][0];
                int right = intervals[j][1];
                int size = right - left + 1;

                pq.Enqueue((size, right), size);
                j++;
            }

            while (pq.Count > 0 && pq.Peek().right < query)
                pq.Dequeue();

            result[idx] = pq.Count > 0 ? pq.Peek().size : -1;
        }

        return result;
    }
}
