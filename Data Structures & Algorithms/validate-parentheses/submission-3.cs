public class Solution {
    public bool IsValid(string s) {
        bool isValid = false;
        if (string.IsNullOrWhiteSpace(s)) return isValid;
        Stack<char> data = new(s.Length);
        foreach (var c in s)
        {
            if (c == '(' || c == '[' || c == '{')            
                data.Push(c);            
            else if (c == ')' || c == ']' || c == '}')
            {
                if (data.Count == 0) return isValid;

                var top = data.Pop();
                if (c == ')' && top != '(') return isValid;
                if (c == ']' && top != '[') return isValid;
                if (c == '}' && top != '{') return isValid;
            }
            else
            {
                // If only brackets are allowed, this is invalid:
                return isValid;
            }
        }
        return data.Count == 0;
    }
}
