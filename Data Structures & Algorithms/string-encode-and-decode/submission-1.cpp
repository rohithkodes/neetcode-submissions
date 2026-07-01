class Solution {
public:

    string encode(vector<string>& strs) {
                string encoded = "";

        for (const string &s : strs)
        {
            int length = s.length();
            int count = 1;
            while (length / 10 > 0)
            {
                length = length / 10;
                count++;
            }
            encoded = encoded + to_string(count) + to_string(s.length()) + s;
        }

        return encoded;
    }

    vector<string> decode(string s) {
        vector<string> decoded;

        int length = 0;
        int count = -1;
        bool foundLength = false;

        string letters = "";

        for (int i = 0; i < s.length(); i++)
        {
            if (count < 0)
            {
                count = s[i] - '0';
                continue;
            }

            if (foundLength == false)
            {
                for (int j = 0; j < count; j++)
                {
                    length = length * 10 + (s[i + j] - '0');
                }

                if (length == 0)
                {
                    decoded.push_back("");
                    count = -1;
                    length = 0;
                    continue;
                }
                else
                {
                    foundLength = true;
                    i += count - 1;
                    continue;
                }
            }
            else
            {
                letters.push_back(s[i]);
                length--;

                if (length == 0)
                {
                    foundLength = false;
                    count = -1;
                    length = 0;

                    decoded.push_back(letters);
                    letters.clear();
                }
            }
        }

        return decoded;
    }
};
