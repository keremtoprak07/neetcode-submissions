public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //value->index
        
        Dictionary<int,int> dict=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++){
            dict[nums[i]]=i;
        }

        for(int j=0;j<nums.Length;j++){
            int diff=target-nums[j];

            if(dict.ContainsKey(diff)&& dict[diff]!=j){
                return new int[] {j,dict[diff]};
            }
        }

        return new int[0];
        

       
        
        
}
}
