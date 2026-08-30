public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        foreach (var s in strs)
        {
            int[] freq = new int[26];

            foreach (char c in s)
                freq[c - 'a']++;

            // Build a unique key like "1#0#2#0#..."
            string key = string.Join("#", freq);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(s);
        }

        return map.Values.ToList();
    }
}
