public class Solution {
    public string MinWindow(string s, string t) {
        if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        return "";

    int[] need = new int[128];
    int required = t.Length;

    foreach (char c in t)
        need[c]++;

    int left = 0, start = 0;
    int minLen = int.MaxValue;

    for (int right = 0; right < s.Length; right++)
    {
        char rc = s[right];

        if (need[rc] > 0)
            required--;

        need[rc]--;

        while (required == 0)
        {
            if (right - left + 1 < minLen)
            {
                minLen = right - left + 1;
                start = left;
            }

            char lc = s[left];
            need[lc]++;

            if (need[lc] > 0)
                required++;

            left++;
        }
    }

    return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
    }
}
