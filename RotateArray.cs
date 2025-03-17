public class Solution {
    public void Rotate(int[] nums, int k) {
         int[] newNums=new int[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
        int newIndex = (i + k) % nums.Length;
        newNums[newIndex] = nums[i];
        }
        for(int i=0;i<newNums.Length;i++)
        {
            nums[i]=newNums[i];
        }
    }
}
