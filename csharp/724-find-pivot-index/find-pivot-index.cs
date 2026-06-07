public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0 ;
       for(int i = 0 ; i < nums.Length ; i++){
            sum += nums[i];
       }
       int check = 0;
       for( int i = 0; i < nums.Length ; i ++){
            int sumtotal = sum - check - nums[i];
            if(check == sumtotal){
                return i ;
            }
            check += nums[i];
       }
       return -1 ;
       
    }
}