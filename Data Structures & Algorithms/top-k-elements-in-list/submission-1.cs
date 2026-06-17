public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new();
        Dictionary<int, List<int>> freq = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
                dict[nums[i]]++;
            else
                dict.Add(nums[i], 1);
        }

        foreach(var kvp in dict)
        {
            if(freq.ContainsKey(kvp.Value))
                freq[kvp.Value].Add(kvp.Key);
            else
            {
                freq.Add(kvp.Value, new List<int>() { kvp.Key });
            }
        }

        List<int> sortedInt = freq.Keys.ToList();
        sortedInt.Sort();
        sortedInt.Reverse();

        List<int> result = new List<int>();

        for(int i = 0; i < sortedInt.Count; i++)
        {
            if(freq[sortedInt[i]].Count == 0)
            {
                Console.WriteLine("Not going to loop within Freq " + sortedInt[i] + " because count is " + freq[sortedInt[i]].Count);
                continue;
            }

            for(int j = 0; j < freq[sortedInt[i]].Count; j++)
            {
                Console.WriteLine("Looping within Freq " + sortedInt[i]);

                result.Add(freq[sortedInt[i]][j]);
                if(result.Count == k) return result.ToArray();
            }
        }

        return new int[1] { -1 };
    }
}
