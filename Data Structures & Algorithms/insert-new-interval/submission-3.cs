public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int i = 0;
        int n = intervals.Length;
        var result = new List<int[]>();

        // 1. Add all intervals ending before newInterval starts
        while (i < n && intervals[i][1] < newInterval[0])
        {
            result.Add(intervals[i]);
            i++;
        }

        // 2. Merge all overlapping intervals
        while (i < n && intervals[i][0] <= newInterval[1])
        {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }

        // Add the merged interval
        result.Add(newInterval);

        // 3. Add remaining intervals
        while (i < n)
        {
            result.Add(intervals[i]);
            i++;
        }
        return result.ToArray();
    }
}
