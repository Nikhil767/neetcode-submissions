public class Solution {
    public int CharacterReplacement(string s, int k) {
        int[] freq = new int[26];
    int left = 0, maxFreq = 0, result = 0;

    for (int right = 0; right < s.Length; right++)
    {
        int idx = s[right] - 'A';
        freq[idx]++;
        maxFreq = Math.Max(maxFreq, freq[idx]);

        // If window is invalid, shrink from the left
        while ((right - left + 1) - maxFreq > k)
        {
            freq[s[left] - 'A']--;
            left++;
        }

        result = Math.Max(result, right - left + 1);
    }

    return result;
    }
}
