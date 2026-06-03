public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length != t.Length) return false;

        Dictionary<char, int> stringAHash = new();

        for(int i = 0; i < s.Length; i++)
        {
            if(stringAHash.ContainsKey(s[i]))
                stringAHash[s[i]]++;
            else
                stringAHash.Add(s[i], 0);
        }
        
        for(int i = 0; i < t.Length; i++)
        {
            if(stringAHash.ContainsKey(t[i]))
                if(stringAHash[t[i]] == 0)
                    stringAHash.Remove(t[i]);
                else
                    stringAHash[t[i]]--;
            else
                return false;
        }

        if(stringAHash.Count == 0)
            return true;
        else
            return false;
    }
}
