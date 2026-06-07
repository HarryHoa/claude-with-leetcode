public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int right = 1 ; 
        if(nums.Length == 0 )
            return 0 ;
        for(int i = 1 ; i < nums.Length  ; i ++){
            if(nums[i] != nums[i-1]){
                nums[right] = nums[i];
                right++;
            }
           
        }
        return right ;
    }
}