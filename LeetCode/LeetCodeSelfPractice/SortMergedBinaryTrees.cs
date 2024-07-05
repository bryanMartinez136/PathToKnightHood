namespace LeetCodeSelfPractice
{
    public class SortMergedBinaryTrees
    {
        public static IList<int> GetAllElements(TreeNode root1, TreeNode root2)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();
            var ans = new List<int>();
            Traverse(root1, list1);
            Traverse(root2, list2);
            SortList(ans, list1, list2);
            return ans;
        }

        private static void Traverse(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            Traverse(root.left, list);
            list.Add(root.val);
            Traverse(root.right, list);
        }

        private static void SortList(List<int> ans, List<int> l1, List<int> l2)
        {
            var left = 0;
            var right = 0;
            // go index by lindex in the two list and add to the third list the smaller values first
            while (left < l1.Count && right < l2.Count)
            {
                if (l1[left] < l2[right])
                {
                    ans.Add(l1[left]);
                    left++;
                }
                else
                {
                    ans.Add(l2[right]);
                    right++;
                }
            }
            // now we want to append the values from the remaining list 
            // the while loop will be skipped for list 1 if all its values have been processed already
            while (left < l1.Count)
            {
                ans.Add(l1[left]);
                left++;
            }
            // add the remaining value from list 2
            while (right < l2.Count)
            {
                ans.Add(l2[right]);
                right++;
            }
        }
    }
}