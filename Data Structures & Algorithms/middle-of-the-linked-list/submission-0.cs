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
    public ListNode MiddleNode(ListNode head) {
        ListNode current = head;
        int length = 0;
        while(current != null){
            length++;
            current = current.next;
        }

        int middle = length / 2;

        current = head;
        for(int i = 0; i < middle; i++){
            current = current.next;
        }

        return current;
    }
}