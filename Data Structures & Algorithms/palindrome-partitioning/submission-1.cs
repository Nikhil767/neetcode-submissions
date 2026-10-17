public class Solution {
    public List<List<string>> Partition(string s) {

       var result = new List<List<string>>();
       var current = new List<string>();
       Backtrack(0);

       return result;

       void Backtrack(int start)
       {
           if (start == s.Length)
           {
               result.Add(new List<string>(current));
               return;
           }

           for (int end = start; end < s.Length; end++)
           {
               if (IsPalindrome(s, start, end))
               {
                   current.Add(s.Substring(start, end - start + 1));
                   Backtrack(end + 1);
                   current.RemoveAt(current.Count - 1);
               }
           } 
       }

       bool IsPalindrome(string str, int left, int right)
       {
           while (left < right)
           {
               if (str[left] != str[right])
                   return false;
               left++;
               right--;
           }
           return true;
       }
    }
}
