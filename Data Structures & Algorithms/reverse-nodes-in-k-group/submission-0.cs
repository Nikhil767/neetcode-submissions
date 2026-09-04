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

public class Solution {
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 1)
            return head;

        ListNode dummy = new ListNode(0, head);
        ListNode groupPrev = dummy;

        while (true)
        {
            // 1. Find the kth node from groupPrev
            ListNode kth = GetKthNode(groupPrev, k);
            if (kth == null)
                break; // fewer than k nodes left → stop

            ListNode groupNext = kth.next;

            // 2. Reverse the group
            ListNode prev = groupNext;
            ListNode curr = groupPrev.next;

            while (curr != groupNext)
            {
                ListNode temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            // 3. Reconnect reversed group
            ListNode temp2 = groupPrev.next;
            groupPrev.next = kth;
            groupPrev = temp2;
        }

        return dummy.next;
    }

    private ListNode GetKthNode(ListNode start, int k)
    {
        while (start != null && k > 0)
        {
            start = start.next;
            k--;
        }
        return start;
    }
}
