public class Solution {

    private const char hash='#';
    public string Encode(IList<string> strs) {
        if(strs is null || strs.Count() < 1) return string.Empty;
        StringBuilder sb = new();
        foreach(string s in strs)
        {            
            var len = s?.Length ?? 0;
            sb.Append(len);
            sb.Append(hash);
            if (len > 0)
                sb.Append(s);
            
        }
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        if (string.IsNullOrEmpty(s))
            return result;
        int i = 0;
        int n = s.Length;

        while (i < n)
        {
            // Find separator
            int j = i;
            while (j < n && s[j] != hash)
                j++;

            // Parse length
            int len = int.Parse(s.Substring(i, j - i));

            // Extract string
            int start = j + 1;
            string str = len == 0 ? string.Empty : s.Substring(start, len);

            result.Add(str);
            i = start + len;
        }
        return result;
   }
}
