/*1409. Queries on a Permutation With Key
*/

namespace LeetCodeSelfPractice
{
    public class QueriesPermutationsWithKey
    {
        public static void Main()
        {
            System.Console.WriteLine("Hello from Self Practice Project !");
        }
        public static int[] ProcessQueries(int[] queries, int m)
        {
            var indicesMap = new Dictionary<int, int>();

            var list = new List<int>();
            for (int i = 1; i <= m; i++)
            {
                list.Add(i);
            }

            var ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var val = queries[i];
                var index = list.IndexOf(val);
                ans[i] = index;
                list.RemoveAt(index);
                list.Insert(0, val);
            }
            return ans;
        }
    }
}
