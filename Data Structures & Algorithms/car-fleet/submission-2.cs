public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        
        Array.Sort(position, speed);

        Stack<double> allTimes = new Stack<double>(); // 1. Stack
        Stack<double> fleets = new Stack<double>();   // 2. Stack

        int length = position.Length;
        
        // 1. ADIM: Düz döngü ile tüm süreleri 1. Stack'e at.
        // En son eklenen eleman (en üstteki), hedefe en yakın araba olur.
        for(int i = 0; i < length; i++) {
            double time = (double)(target - position[i]) / speed[i];
            allTimes.Push(time);
        }

        // 2. ADIM: 1. Stack boşalana kadar elemanları çek (Pop)
        while(allTimes.Count > 0) {
            double currentCarTime = allTimes.Pop(); // Otomatik olarak en öndekinden geriye doğru gelir!

            // Klasik filo yakalama mantığımız
            if(fleets.Count == 0 || currentCarTime > fleets.Peek()) {
                fleets.Push(currentCarTime); // Yetişemez, yeni filo!
            }
            // Aksi durumda (currentCarTime <= fleets.Peek()) yetişir, hiçbir şey yapma.
        }

        return fleets.Count;
    }
}