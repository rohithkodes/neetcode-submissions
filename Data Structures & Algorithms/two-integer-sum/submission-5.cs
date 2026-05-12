public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new();

        int diff = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            diff = target - nums[i];

            if(dict.ContainsKey(diff))
                return new int[2] { dict[diff], i };
            else
                dict.Add(nums[i], i);
        }

        return new int[] {};
    }
}
