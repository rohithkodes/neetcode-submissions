public class Solution {
    public bool hasDuplicate(int[] nums) {
        List<int> list = new();

        for(int i = 0; i < nums.Length; i++)
        {
            if(list.Contains(nums[i]))
                return true;
            else
                list.Add(nums[i]);
        }

        return false;
    }
}