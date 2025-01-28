public class Solution {
    public int MajorityElement(int[] nums) {
int counter = 0;
int candidate = 0;

foreach (int num in nums) {
    if (counter == 0) {
        candidate = num;
    }
     
        if(candidate==num)
        {
            counter+=1;
        
        }
        else counter-=1;
        
    
}

int count = 0;
foreach (int num in nums) {
    if (num == candidate) {
        count++;
    }
}

if (count > nums.Length / 2) {
    return candidate;
}
return -1;

    }
}
