public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left=1;
        int right=0  ;

        foreach(int i in piles){
            if(i>right){
                right=i;
            }

        }
        int answer=right;


        while(right>=left){
            int mid=left+(right-left)/2;

            long totalhours=0;

            foreach(int pile in piles){
                totalhours+=(long)(pile+mid-1L)/mid;
            }
            if(totalhours<=h){
                answer=mid;
                right=mid-1;

            }
            else{ 
                left=mid+1;
            }




        }
        return answer;

        
    }
}
