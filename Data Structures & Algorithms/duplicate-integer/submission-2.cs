public class Solution {
    public bool hasDuplicate(int[] nums) {

        int current;

        for(int i=0;i<nums.Length;i++){
            current=nums[i];
            for(int j=i+1;j<nums.Length;j++){
                if(nums[j]==current){
                    return true;
                }
                
            }

        }
        return false;
        
    }
}