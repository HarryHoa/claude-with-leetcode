public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int check = 0 ; 
        for(int i = 0 ; i < nums.Length; i ++){
            if(nums[i] != val){
                nums[check] = nums[i]; 
                check++;
            }
        }
        return check ; 
    }
}