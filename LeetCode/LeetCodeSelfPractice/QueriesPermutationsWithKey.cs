/*1409. Queries on a Permutation With Key
Given the array queries of positive integers between 1 and m, you have to process all queries[i] 
(from i=0 to i=queries.length-1) according to the following rules:

In the beginning, you have the permutation P=[1,2,3,...,m].
For the current i, find the position of queries[i] in the permutation P (indexing from 0)
and then move this at the beginning of the permutation P. Notice that the position of queries[i] in P is the result for queries[i].
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
            // first, we create a list of numbers from 1 to m
            var list = new List<int>();
            for (int i = 1; i <= m; i++)
            {
                list.Add(i);
            }

            // this will be the array where we insert the indices
            // alternatively, we can just reuse the queries arrays
            var ans = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                // we get the first value
                var val = queries[i];
                // then we find its index in the list
                var index = list.IndexOf(val);
                // which we then assign to the answer array
                ans[i] = index;
                // we then remove the value at that index
                list.RemoveAt(index);
                // and we insert the value to the beginning of the list
                list.Insert(0, val);
            }
            return ans;
        }
    }
}
