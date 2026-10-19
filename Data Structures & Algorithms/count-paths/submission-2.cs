public class Solution {
    public int UniquePaths(int m, int n) {
        int totalSteps = m + n - 2;
        
        int k = Math.Min(m - 1, n - 1);
        
        long result = 1;

        
        for (int i = 1; i <= k; i++) {
            result = result * (totalSteps - k + i) / i;
        }

        return (int)result;
    }
}