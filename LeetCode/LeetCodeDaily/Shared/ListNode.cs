namespace LeetCodeDaily
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

        public int[] ToArray()
        {
            int size = 0;
            var temp = this;
            while (temp != null)
            {
                size++;
                temp = temp.next;
            }
            int[] array = new int[size];
            temp = this;
            for (int i = 0; i < size; i++)
            {
                array[i] = temp.val;
                temp = temp.next;
            }
            return array;
        }

        public void AddValues(int[] array)
        {
            var head = this;
            for (int i = 0; i < array.Length; i++)
            {
                head.next = new ListNode(array[i]);
                head = head.next;
            }
        }
    }

}