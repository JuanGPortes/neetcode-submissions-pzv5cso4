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
        List<int> values = new List<int>();
        ListNode current = head;

        while(current != null){
            values.Add(current.val);
            current = current.next;
        }

        int maxSum = 0;

        int left = 0;
        int right = values.Count - 1;

        while(left < right){
            int currentSum = values[left] + values[right];
            maxSum = Math.Max(currentSum, maxSum);

            left++;
            right--;
        }

        return maxSum;
    }
}