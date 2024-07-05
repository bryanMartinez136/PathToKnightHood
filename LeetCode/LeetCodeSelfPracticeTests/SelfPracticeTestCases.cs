using System;
using NUnit.Framework;
using LeetCodeSelfPractice;

namespace LeetCodeSelfPracticeTests
{

    public class SelfPracticeTestCases
    {
        [Test, Description("1409. Queries on a Permutation With Key")]
        public void QueriesPermutationsWithKey_Test()
        {
            var q1 = new int[] { 3, 1, 2, 1 };
            var q2 = new int[] { 4, 1, 2, 2 };
            var q3 = new int[] { 7, 5, 5, 8, 3 };
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q1, 5), Is.EqualTo(new int[] { 2, 1, 2, 1 }));
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q2, 4), Is.EqualTo(new int[] { 3, 1, 2, 0 }));
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q3, 8), Is.EqualTo(new int[] { 6, 5, 0, 7, 5 }));
        }

        [Test, Description("1305. All Elements in Two Binary Search Trees")]
        public void SortMergedBinaryTreesTest()
        {
            var tree1_test1 = new TreeNode(2, new TreeNode(1), new TreeNode(4));
            var tree2_test1 = new TreeNode(1, new TreeNode(0), new TreeNode(3));
            var tree1_test2 = new TreeNode(1, null, new TreeNode(8));
            var tree2_test2 = new TreeNode(8, new TreeNode(1), null);
            Assert.That(SortMergedBinaryTrees.GetAllElements(tree1_test1, tree2_test1), Is.EqualTo(new List<int>() { 0, 1, 1, 2, 3, 4 }));
            Assert.That(SortMergedBinaryTrees.GetAllElements(tree1_test2, tree2_test2), Is.EqualTo(new List<int>() { 1, 1, 8, 8 }));
        }
    }
}