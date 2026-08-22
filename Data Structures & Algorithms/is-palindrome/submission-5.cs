public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        bool isPalindrome = true;
        int start = 0;
        int end = s.Length - 1;
        while(start < end)
        {
            if (!char.IsLetterOrDigit(s[start]))
            {
                start++;
                continue;
            }
            if (!char.IsLetterOrDigit(s[end]))
            {
                end--;
                continue;
            }
            if ((0x20 | s[start]) != (s[end] | 0x20))
                return false;
            start++;
            end--;
        }
        return isPalindrome;
    }
}
