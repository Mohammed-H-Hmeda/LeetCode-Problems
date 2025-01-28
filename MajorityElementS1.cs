public class Solution {
    public int MajorityElement(int[] nums) {
        int currentNum;
        int occurenses;
   for(int i=0;i<nums.Length;i++)
       {
        occurenses=1;
        currentNum=nums[i];
        if(nums.Length==1)
        {
            return currentNum;
        }
        else{
        for(int ii=i+1;ii<nums.Length;ii++)
        {
            if(currentNum==nums[ii])
            {
                occurenses+=1;
                if(occurenses>(nums.Length/2))
                {
                   return currentNum;
                   break;
                }
            }
        }
        }
        
       }
       return -1;

    }
}
