/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if (intervals == null || intervals.Count == 0)
            return true;

        // Sort intervals by start time
        intervals.Sort((a, b) => a.start.CompareTo(b.start));

        for (int i = 1; i < intervals.Count; i++)
        {
            // If current meeting starts before previous meeting ends → conflict
            if (intervals[i].start < intervals[i - 1].end)
                return false;
        }

        return true;
    }
}
