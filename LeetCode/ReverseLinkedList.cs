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

// Method - 1:
public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null, curr = head;
        while (curr != null)
        {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }
        return prev;
    }
}

// Method - 2 (Recursive):
public class Solution
{
    public ListNode ReverseList(ListNode head, ListNode previos = null)
    {
        if (head == null)
        {
            return previos;
        }
        ListNode nxt = head.next;
        head.next = previos;
        previos = head;
        head = nxt;
        return ReverseList(head, previos);
    }
}
