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

        ReadOnlySpan<char> span = s.AsSpan();
        int i = 0;
        int n = span.Length;
        while (i < n)
        {
            // Find separator '#'
            int sep = span.Slice(i).IndexOf(hash);
            if (sep == -1)
                break; // malformed, but keeps it safe

            int lenStart = i;
            int lenLen = sep;

            int len = int.Parse(span.Slice(lenStart, lenLen));

            int start = i + sep + 1;
            string str = len == 0 ? string.Empty : span.Slice(start, len).ToString();
            result.Add(str);

            i = start + len;
        }

        return result;
   }
}
