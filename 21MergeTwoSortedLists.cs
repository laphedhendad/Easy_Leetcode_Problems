/*
 * Merge two sorted linked lists and return it as a sorted list.
 * The list should be made by splicing together the nodes of the first two lists.
 */

using System;
using System.Collections.Generic;


namespace MergeToSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Solution
    {
        static public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null) return l1 == null ? l2 : l1;

            ListNode output = new ListNode();
            ListNode current = output;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }

                current = current.next;
            }

            current.next = l1 == null ? l2 : l1;

            return output.next;
        }
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(4);
            ListNode node2 = new ListNode(2, node1);
            ListNode node3 = new ListNode(4);
            ListNode node4 = new ListNode(3, node3);
            ListNode node5 = new ListNode(1, node4);
            ListNode output = MergeTwoLists(node2, node5);
        }
    }
}
