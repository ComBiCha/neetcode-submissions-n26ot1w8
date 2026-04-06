public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        if(s.Length == 1) return false;
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                st.Push(s[i]);
            }
            if(st.Count == 0) return false;
            if(s[i] == ')' && st.Pop() != '(') return false;
            if(s[i] == ']' && st.Pop() != '[') return false;
            if(s[i] == '}' && st.Pop() != '{') return false;
        }
        if(st.Count > 0) return false;
        return true;
    }
}
