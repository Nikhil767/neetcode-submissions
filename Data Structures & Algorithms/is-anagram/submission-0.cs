public class Solution {
    public bool IsAnagram(string s, string t) {
        bool result = false;
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return result;
        if(s.Length != t.Length) return result;

        return IsAnagramByFrequencyArray(s,t);
    }

    public bool IsAnagramByFrequencyArray(string s, string t) {
        bool result = false;
        int[] count= new int[26];        
        for(int i=0; i<s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }        
        for(int j=0; j<count.Length; j++)
        {
            if(count[j] != 0)
                return result;
        }
        result=true;
        return result; 
    }
}
