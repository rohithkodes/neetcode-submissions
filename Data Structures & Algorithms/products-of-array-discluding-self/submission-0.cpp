class Solution {
public:
    vector<int> productExceptSelf(vector<int>& nums) {
        int length = nums.size();

        vector<int> output(length);
        vector<int> leftProduct(length);

        leftProduct[0] = 1;
        int product = 1;

        for(int i = 1; i < length; i++)
        {
            product = product * nums[i - 1];
            leftProduct[i] = product;
        }

        int rightProduct = 1;

        output[length - 1] = rightProduct * leftProduct[length - 1];

        for(int i = length - 2; i >= 0; i--)
        {
            rightProduct = rightProduct * nums[i + 1];
            output[i] = rightProduct * leftProduct[i];
        }

        return output;
    }
};
