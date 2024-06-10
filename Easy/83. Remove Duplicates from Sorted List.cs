public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if (head == null){
            return head;
        }
        ListNode current = head;
        while (current.next != null && current != null){
            if (current.val == current.next.val){
                current.next = current.next.next;
                }
            else{
                current = current.next;
                }
            }
        return head;
    }
}
