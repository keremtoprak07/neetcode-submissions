public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        // Liste boşsa veya hiç eleman yoksa null dön
        if (lists == null || lists.Length == 0) return null;
        
        // C#'taki Min-Heap yapısı.
        // Element: ListNode (Düğümün kendisi)
        // Priority: int (Düğümün değeri, küçük olan öne geçer)
        PriorityQueue<ListNode, int> pq = new PriorityQueue<ListNode, int>();
        
        // 1. Adım: Tüm listelerin sadece BAŞLANGIÇ düğümlerini kuyruğa ekle
        foreach (var head in lists) {
            if (head != null) {
                pq.Enqueue(head, head.val);
            }
        }
        
        // "Dummy Node" (Kukla Düğüm) Tekniği: 
        // Yeni listenin başını kaybetmemek ve if(null) kontrollerinden kurtulmak için kullanılır.
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        
        // 2. Adım: Kuyruk boşalana kadar en küçük elemanı çek ve zincire ekle
        while (pq.Count > 0) {
            // Kuyruktaki en küçük değerli düğümü al
            ListNode node = pq.Dequeue();
            
            // Asıl zincirimize bağla ve bir adım ilerle
            current.next = node;
            current = current.next;
            
            // Eğer çektiğimiz düğümün arkasında başka bir vagon varsa, onu da kuyruğa ekle
            if (node.next != null) {
                pq.Enqueue(node.next, node.next.val);
            }
        }
        
        // Kukla düğümün (0) bir sonrasından itibaren asıl sıralı listemiz başlar
        return dummy.next;
    }
}