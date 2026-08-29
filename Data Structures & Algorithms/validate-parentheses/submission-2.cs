public class Solution {
    public bool IsValid(string s) {
        if (string.IsNullOrWhiteSpace(s)) return true;
        Stack<char> data = new(s.Length);
        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')            
                data.Push(c);            
            else if (c == ')' || c == ']' || c == '}')
            {
                if (data.Count == 0) return false;

                var top = data.Pop();
                if (c == ')' && top != '(') return false;
                if (c == ']' && top != '[') return false;
                if (c == '}' && top != '{') return false;
            }
            else
            {
                // If only brackets are allowed, this is invalid:
                return false;
            }
        }
        return data.Count == 0;
    }
}
