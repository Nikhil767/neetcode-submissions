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
    public ListNode MergeKLists(ListNode[] lists) {
       if (lists is null || lists.Length == 0)
            return null;

        PriorityQueue<ListNode, int> minHeap = new();
        foreach (var node in lists)
        {
            if (node != null)
                minHeap.Enqueue(node, node.val);
        }

        ListNode dummy = new(0);
        ListNode current = dummy;

        while (minHeap.Count > 0)
        {
            ListNode node = minHeap.Dequeue();

            current.next = node;
            current = current.next;

            if (node.next != null)
                minHeap.Enqueue(node.next, node.next.val);
        }

        return dummy.next; 
    }
}
