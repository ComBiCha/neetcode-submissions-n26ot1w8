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
    public ListNode ReverseList(ListNode head) {
        if(head == null || head.next == null) return head;
        ListNode nextNode = new ListNode();
        ListNode prevNode = new ListNode();
        int first = 1;
        while(head.next != null)
        {
            nextNode = head.next;
            if(first == 1)
            {
                head.next = null;
                first++;
                prevNode = head;
            }
            else
            {
                head.next = prevNode;
                prevNode = head;
            }
            head = nextNode;
        }
        head.next = prevNode;
        return head;
    }
}
