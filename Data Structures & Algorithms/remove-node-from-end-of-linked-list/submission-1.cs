public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(-1);
        dummy.next = head;
        
        ListNode slow = dummy;
        ListNode fast = dummy;
        
        // 1. Fast pointer'ı n adım ileri taşı
        for (int i = 0; i <= n; i++) {
            fast = fast.next;
        }
        
        // 2. Fast sona ulaşana kadar ikisini de eşit hızda ilerlet
        while (fast != null) {
            slow = slow.next;
            fast = fast.next;
        }
        
        // 3. Fast null olduğunda, slow silinecek düğümün tam arkasındadır
        slow.next = slow.next.next;
        
        return dummy.next;
    }
}