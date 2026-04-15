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
    public bool HasCycle(ListNode head) {
        var set = new HashSet<ListNode>();
        if(head == null || head.next == null) return false;
        while(head != null)
        {
            if(set.Contains(head))
            {
                return true;
            }
            else
            {
                set.Add(head);
            }
            head = head.next;
        }
        return false;
    }
}
