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
        HashSet<ListNode> set = new HashSet<ListNode>();

        ListNode current = head;

        while(current != null){
            if(!set.Add(current)){
                return true;
            }

            current = current.next;
        }

        return false;
    }
}
