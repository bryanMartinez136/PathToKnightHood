namespace LeetCodeDaily
{
    public class MergeNodesBetweenZero
    {
        public static ListNode MergeNodes(ListNode head)
        {
            var left = head.next;
            var right = left.next;
            while (right != null)
            {
                if (right.val == 0 && right.next != null)
                {
                    right = right.next;
                    left.next = right;
                    left = left.next;
                }
                else if (right.val == 0)
                {
                    left.next = right.next;
                }
                else
                {
                    left.val += right.val;
                }
                right = right.next;
            }

            return head.next;
        }

    }
}