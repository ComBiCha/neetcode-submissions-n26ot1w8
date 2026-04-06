public class Solution {
    public bool IsAnagram(string s, string t) {
        var dic = new Dictionary<char, int>();
        if(s.Length != t.Length) return false;
        for(int i = 0; i < s.Length; i++)
        {
            if(!dic.ContainsKey(s[i]))
            {
                dic.Add(s[i], 1);
            }
            else
            {
                dic[s[i]]++;
            }

            if(!dic.ContainsKey(t[i]))
            {
                dic.Add(t[i], -1);
            }
            else
            {
                dic[t[i]]--;
            }
        }
        foreach(var pair in dic)
        {
            if(pair.Value != 0) return false;
        }
        return true;
    }
}
