public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int n=matrix.Length;
        int m=matrix[0].Length;
        int left=0;
        int right=m*n-1;

        

        while(left<=right){
            int mid=left+(right-left)/2;
            int midj=mid/m;//hangi satır verir
            int midi=mid%m;//hangi sütun verir

            if(matrix[midj][midi]<target){
                left=mid+1;

            }
            if(matrix[midj][midi]>target){
                right=mid-1;
            }
            if(matrix[midj][midi]==target){
                return true;
            }



        }
        return false;
        

        
    }
}
