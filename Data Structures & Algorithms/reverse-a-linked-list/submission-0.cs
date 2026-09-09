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
        if(head == null || head.next == null){
            return head;
        }

        Stack<ListNode> s = new Stack<ListNode>();
        ListNode curr = head;

        while(curr != null){
            s.Push(curr);
            curr = curr.next;
        }

        ListNode newHead = s.Pop();
        curr = newHead;

        while(s.Count > 0){
            curr.next = s.Pop();
            curr = curr.next;
        }
        curr.next = null;

        return newHead;
    }
}
