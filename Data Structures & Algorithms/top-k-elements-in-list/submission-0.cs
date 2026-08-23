public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var counts = new Dictionary<int, int>();
        foreach (var n in nums) {
            counts[n] = counts.GetValueOrDefault(n, 0) + 1;
        }

        // Index = frequency, Value = list of numbers with that frequency
        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (var pair in counts) {
            int freq = pair.Value;
            if (buckets[freq] == null) buckets[freq] = new List<int>();
            buckets[freq].Add(pair.Key);
        }

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            if (buckets[i] != null) {
                result.AddRange(buckets[i]);
            }
        }

        return result.Take(k).ToArray();
    }
}
