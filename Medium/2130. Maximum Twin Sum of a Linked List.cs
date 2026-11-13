/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public int PairSum(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode prev = null;
        ListNode current = slow;

        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        ListNode secondHalf = prev;
        int max = 0;

        while (secondHalf != null){
            int currentSum = head.val + secondHalf.val;
            max = Math.Max(max, currentSum);
            head = head.next;
            secondHalf = secondHalf.next;
        }

        return max;
    }
}
