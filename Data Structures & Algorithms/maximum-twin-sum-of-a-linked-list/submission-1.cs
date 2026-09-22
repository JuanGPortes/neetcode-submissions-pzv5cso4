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
    public int PairSum(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;

        //find the middle
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        // invert the second half
        ListNode prev = null;
        ListNode current = slow;
        while(current != null){
            ListNode nextTemp = current.next;

            current.next = prev;
            prev = current;
            current = nextTemp;
        }

        int maxSum = 0;
        ListNode firstHalf = head;
        ListNode secondHalf = prev;
        
        while(secondHalf != null){
            int currentSum = firstHalf.val + secondHalf.val;

            maxSum = Math.Max(maxSum, currentSum);

            firstHalf = firstHalf.next;
            secondHalf = secondHalf.next;
        }

        return maxSum;
    }
}