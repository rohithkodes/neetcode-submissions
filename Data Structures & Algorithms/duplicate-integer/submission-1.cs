public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> tracker = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(tracker.ContainsKey(nums[i])) return true;
            tracker.Add(nums[i], 0);
        }

        return false;
    }
}