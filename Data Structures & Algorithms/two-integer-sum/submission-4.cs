public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int find = target - nums[i];
            if(dic.ContainsKey(find))
            {
                return new[] {dic[find], i};
            }
            else
            {
                dic.Add(nums[i], i);
            }
        }
        return new[] {0,0};
    }
}
