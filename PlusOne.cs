public class Solution {
    int total;
    public int[] PlusOne(int[] digits) {
        int lastvalue=digits.Length-1;
        for(int i=digits.Length-1; i>=0;i--)
        {
            if(digits[i]<9)
            {
                digits[i]++;
                return digits;
            }
            else
            {
                digits[i]=0;
            }
           
            
        }
        int[] newArray=new int[digits.Length+1];
        newArray[0]=1;
        return newArray;

    }
}
