public class Solution {
    public int LargestRectangleArea(int[] heights) {
        Stack<int[]> s =new Stack<int[]>();
        int maxarea=0;


        for(int i=0;i<heights.Length;i++){
            int start=i;
            while(s.Count>0&& s.Peek()[1]>heights[i]){
                int[] top=s.Pop();
                int poppedindex=top[0];
                int poppedheight=top[1];

                int currentarea=poppedheight*(i-poppedindex);
                maxarea=Math.Max(maxarea,currentarea);

                start=poppedindex;

                

            }
            s.Push(new int[]{start,heights[i]});

        }
        while(s.Count>0){
            int[] popped=s.Pop();
            int poppedindex=popped[0];
            int poppedheight=popped[1];

            int currentarea=poppedheight*(heights.Length-poppedindex);
            maxarea=Math.Max(maxarea,currentarea);

            
        }
        return maxarea;

        
    }
}
