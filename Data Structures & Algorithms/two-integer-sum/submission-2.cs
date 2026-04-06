public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dic = new Dictionary<int, int>();
        int[] results = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], i);
            }           
        }
        for(int i = 0; i < nums.Length; i++)
        {
            int newtarget = target - nums[i];
            if(dic.ContainsKey(newtarget) && dic[newtarget] != i)
            {
                if(newtarget == nums[i])
                {
                    results = [dic[newtarget], i];
                }
                else
                {
                    results = [i, dic[newtarget]];
                }
                
                return results;
            }
        }
        return results;
    }
}
