public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> dict = new();

        for(int i = 0; i < strs.Length; i++)
        {
            if(dict.Count == 0)
            {
                dict.Add(strs[i], new List<string>() { strs[i] });
                continue;
            }

            bool found = false;

            foreach(var kvp in dict)
            {
                if(IsAnagram(kvp.Key, strs[i]))
                {
                    dict[kvp.Key].Add(strs[i]);
                    found = true;
                    break;
                }
            }

            if(!found)
                dict.Add(strs[i], new List<string>() { strs[i] });
        }

        List<List<string>> result = new();
        int index = 0;
        foreach(var kvp in dict)
        {
            result.Add(new List<string>());

            foreach(string str in dict[kvp.Key])
                result[index].Add(str);

            index++;
        }

        return result;
    }

    public bool IsAnagram(string a, string b)
    {
        if(a.Length != b.Length) return false;

        Dictionary<char, int> newDict = new();

        foreach(char c in a)
        {
            if(newDict.ContainsKey(c)) newDict[c]++;
            else newDict.Add(c, 1);
        }

        foreach(char c in b)
        {
            if(newDict.ContainsKey(c))
            {
                if(newDict[c] == 0)
                    return false;
                else newDict[c]--;
            }
            else
                return false;
        }

        foreach(var kvp in newDict)
        {
            if(newDict[kvp.Key] > 0)
                return false;
        }

        return true;
    }
}
