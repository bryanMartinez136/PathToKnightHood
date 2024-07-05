using System;
using NUnit.Framework;
using LeetCodeDaily;

namespace LeetCodeDailyTests
{

    public class LeetCodeDailyTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GrumpyBoss_tests()
        {
            int[] test_customers_1 = { 1, 2, };
            int[] grumpy_1 = { 1, 0, };
            int[] test_customers_2 = { 1, 2, 3, 4, 5 };
            int[] grumpy_2 = { 1, 0, 0, 0, 1 };
            int[] test_customers_3 = { 1, 2, 77 };
            int[] grumpy_3 = { 1, 0, 1 };
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_1, grumpy_1, 1), Is.EqualTo(3));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_2, grumpy_2, 4), Is.EqualTo(14));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_2, grumpy_2, 5), Is.EqualTo(15));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_3, grumpy_3, 1), Is.EqualTo(79));
        }

        [Test, Description("LC-1438")]
        public void LongestContigSubArray()
        {
            int[] nums = { 8, 2, 4, 7 };
            int[] nums2 = [4, 2, 2, 2, 4, 4, 2, 2];
            int[] nums3 = [1, 5, 6, 7, 8, 10, 6, 5, 6];
            Assert.That(ContigSubArrayWithDiffLessThanLimit.LongestSubarray(nums, 4), Is.EqualTo(2));
            Assert.That(ContigSubArrayWithDiffLessThanLimit.LongestSubarray(nums2, 0), Is.EqualTo(3));
            Assert.That(ContigSubArrayWithDiffLessThanLimit.LongestSubarray(nums3, 4), Is.EqualTo(5));
        }

        [Test, Description("LC-2128")]
        public void MergeNodesTest()
        {
            ListNode head = new ListNode(0, new ListNode(3, new ListNode(1, new ListNode(0, new ListNode(4, new ListNode(5, new ListNode(2, new ListNode(0, null))))))));
            ListNode head2 = new ListNode(0, new ListNode(1, new ListNode(0, new ListNode(3, new ListNode(0, new ListNode(2, new ListNode(2, new ListNode(0, null))))))));
            head = MergeNodesBetweenZero.MergeNodes(head);
            head2 = MergeNodesBetweenZero.MergeNodes(head2);
            Assert.That(head.ToArray(), Is.EqualTo(new int[] { 4, 11 }));
            Assert.That(head2.ToArray(), Is.EqualTo(new int[] { 1, 3, 4 }));
        }


        [Test, Description("LC-2128")]
        public void NodesBetweenCriticalPointsTest()
        {
            ListNode head1 = new ListNode(3);
            ListNode head2 = new ListNode(5);
            ListNode head3 = new ListNode(1);
            var head1_vals = new int[] { 1 };
            var head2_vals = new int[] { 3, 1, 2, 5, 1, 2 };
            var head3_vals = new int[] { 3, 2, 2, 3, 2, 2, 2, 7 };
            head1.AddValues(head1_vals);
            head2.AddValues(head2_vals);
            head3.AddValues(head3_vals);
            var arr1 = MinAndMaxNodesBetweenCritPoints.NodesBetweenCriticalPoints(head1);
            var arr2 = MinAndMaxNodesBetweenCritPoints.NodesBetweenCriticalPoints(head2);
            var arr3 = MinAndMaxNodesBetweenCritPoints.NodesBetweenCriticalPoints(head3);
            Assert.That(arr1, Is.EqualTo(new int[] { -1, -1 }));
            Assert.That(arr2, Is.EqualTo(new int[] { 1, 3 }));
            Assert.That(arr3, Is.EqualTo(new int[] { 3, 3 }));
        }
    }
}