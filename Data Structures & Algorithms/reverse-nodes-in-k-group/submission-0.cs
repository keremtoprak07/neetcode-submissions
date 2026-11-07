
public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        
        ListNode curr = head;
        int count = 0;
        
        while (curr != null && count < k) {
            curr = curr.next;
            count++;
        }
        
        if (count < k) {
            return head;
        }
        
        ListNode prev = null;
        ListNode current = head;
        ListNode nextNode = null;
        
        for (int i = 0; i < k; i++) {
            nextNode = current.next;
            current.next = prev;
            prev = current;
            current = nextNode;
        }
        head.next = ReverseKGroup(current, k);
        
        return prev;
    }
}