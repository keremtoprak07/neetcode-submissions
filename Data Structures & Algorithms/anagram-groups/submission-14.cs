public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // 1. Veri Yapısı: Key = "aet" (Sıralı), Value = ["eat", "tea", "ate"] (Orijinal)
        Dictionary<string, List<string>> map = new();

        // 2. Tek Döngü (O(N))
        foreach (string s in strs) {
            
            // 3. Ortak Anahtar Üretme (O(K log K))
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);
            

            // 4. Sözlükte Grup Yoksa Yeni Liste Aç
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            // Orijinal kelimeyi ilgili gruba ekle
            map[key].Add(s);
        }

        // 5. Tüm grupları LeetCode'un istediği formata çevirip döndür
        return new List<List<string>>(map.Values);
    }
}