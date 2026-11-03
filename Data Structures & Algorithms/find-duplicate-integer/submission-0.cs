public class Solution {
    public int FindDuplicate(int[] nums) {
        Array.Sort(nums);

        for(int i =0;i<nums.Length;i++){
            int curr=nums[i];
            for(int j=i+1;j<nums.Length;j++){
                if(curr==nums[j]){
                    return curr;
                }
                
                
            }
        }
        return -1;
        
    }
}
