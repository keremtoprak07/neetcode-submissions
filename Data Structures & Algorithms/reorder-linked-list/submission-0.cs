public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;

        // 1. Orta noktayı bul
        ListNode fast = head;
        ListNode slow = head;

        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }

        // 2. İkinci yarıyı ters çevir
        ListNode curr = slow.next;
        slow.next = null; // Birinci yarıyı kopar (Sonsuz döngüyü engeller)
        ListNode prev = null;
        
        while (curr != null) {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }

        // 3. Fermuar gibi birleştir (Merge)
        ListNode first = head;
        ListNode second = prev; // Ters çevrilmiş kısmın yeni başı

        while (second != null) {
            // Zincirler kopmasın diye sıradaki adresleri güvene al
            ListNode temp1 = first.next;
            ListNode temp2 = second.next;

            // Okları çapraz bağla
            first.next = second;
            second.next = temp1;

            // İşaretçileri bir sonraki düğümlere kaydır
            first = temp1;
            second = temp2;
        }
    }
}