public class Solution {
    public bool IsPalindrome(string s) {

        for(int i = 0, j = s.Length - 1; i < s.Length && j >= 0;)
        {
            if(!Char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }

            if(!Char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            if(Char.ToLower(s[i]) == Char.ToLower(s[j]))
            {
                i++;
                j--;
                continue;
            }
            else
                return false;
        }

        return true;
    }
}
