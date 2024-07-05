namespace LeetCodeDaily
{
    public class MinAndMaxNodesBetweenCritPoints
    {
        public static int[] NodesBetweenCriticalPoints(ListNode head)
        {
            var list = new List<int>();
            var critPoints = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                if (list.Count > 1 && head.next != null)
                {
                    if (head.val > list[list.Count - 2] && head.val > head.next.val)
                    {
                        critPoints.Add(list.Count - 1);
                    }
                    if (head.val < list[list.Count - 2] && head.val < head.next.val)
                    {
                        critPoints.Add(list.Count - 1);
                    }
                }
                head = head.next;
            }
            if (critPoints.Count < 2)
            {
                return new int[] { -1, -1 };
            }

            var min = critPoints[1] - critPoints[0];
            for (int i = 1; i < critPoints.Count; i++)
            {
                min = Math.Min(min, critPoints[i] - critPoints[i - 1]);
            }
            var max = critPoints.Max() - critPoints.Min();

            return new int[] { min, max };
        }
    }
}