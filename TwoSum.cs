public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++)
        {
            for(int si=i+1;si<nums.Length;si++)
            {
                if(nums[i]+nums[si]==target)
                {
                    
                    return new int[] { i, si };
                }
                
            }
        }
         return new int[0];
    }
        
}
