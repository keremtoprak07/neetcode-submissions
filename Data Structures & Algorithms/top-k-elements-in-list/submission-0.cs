public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>();

        // 1. Frekansları say
        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                dict[num] = 0;
            }
            dict[num]++;
        }

        // 2. Sayıları frekanslarına göre büyükten küçüğe sırala ve ilk k tanesini seç
        return dict.OrderByDescending(x => x.Value)
                   .Take(k)
                   .Select(x => x.Key)
                   .ToArray();
    }
}