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
        if(lists == null || lists.Length == 0){
             return null;
        }
        
        List<int> vals = new List<int>();
        
        foreach(ListNode node in lists){
            ListNode current = node;
            while(current != null){
                vals.Add(current.val);
                current = current.next;
            }
        }

        vals.Sort();

        ListNode dummy = new ListNode(-1);
        ListNode currentBuild = dummy;

        foreach(int val in vals){
            currentBuild.next = new ListNode(val);
            currentBuild = currentBuild.next;
        }

        return dummy.next;
    }
}
