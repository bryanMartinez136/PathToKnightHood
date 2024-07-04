/*2181. Merge Nodes in Between Zeros
You are given the head of a linked list, which contains a series of integers separated by 0's. 
The beginning and end of the linked list will have Node.val == 0.

For every two consecutive 0's, merge all the nodes lying in between them into a single node whose
value is the sum of all the merged nodes. The modified list should not contain any 0's.

Return the head of the modified linked list.
*/

namespace LeetCodeDaily
{
    public class MergeNodesBetweenZero
    {
        public static ListNode MergeNodes(ListNode head)
        {
            var left = head;
            var right = left.next;
            // guaranteed 1 node since the start and end must be zero
            // if there is only one node, we skip the loop and just return the head
            while (right != null)
            {
                // if we encounter a zero, and it's not the last zero, 
                // we assign left.next to the node after the zero
                if (right.val == 0 && right.next != null)
                {
                    right = right.next;
                    left.next = right;
                    left = left.next;
                }
                else if (right.val == 0) // however, if the node after zero is null, then we are at the end, so we set the node's next value to be null
                {
                    left.next = right.next;
                }
                else // otherwise, business as usual. Add the values of the right pointer the node at the left pointer. 
                {
                    left.val += right.val;
                }
                // don't forget to increment the right pointer !
                right = right.next;
            }
            // lastly, we return the head of the linked list
            return head;
        }

    }
}