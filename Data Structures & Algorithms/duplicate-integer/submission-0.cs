public class Solution {
    public bool hasDuplicate(int[] nums) {
        var dic = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], 1);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}