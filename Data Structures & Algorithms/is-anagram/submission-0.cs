public class Solution {
    public bool IsAnagram(string s, string t) {
        
        Dictionary<char, int> dict = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
                dict[s[i]]++;
            else
                dict.Add(s[i], 1);
        }

        for(int i = 0; i < t.Length; i++)
        {
            if(dict.ContainsKey(t[i]))
            {
                if(dict[t[i]] == 1)
                    dict.Remove(t[i]);
                else
                    dict[t[i]]--;
            }
            else
                return false; 
        }

        if(dict.Count == 0)
            return true;
        else
            return false;
    }
}
