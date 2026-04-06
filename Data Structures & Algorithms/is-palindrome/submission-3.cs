public class Solution {
    public bool IsPalindrome(string s) {
        int n = s.Length - 1;
        for(int i = 0; i < n; i++)
        {
            bool a = char.IsLetterOrDigit(s[i]);
            bool b = char.IsLetterOrDigit(s[n]);
            if (!a) continue;
            if (!b)
            {
                n--;
                i--;
                continue;
            }
            if(s[i].ToString().ToLower() != s[n].ToString().ToLower()) return false;
            n--;
        }
        return true;
    }
}