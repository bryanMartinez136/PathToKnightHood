using System;
using NUnit.Framework;
using LeetCodeSelfPractice;

namespace LeetCodeSelfPracticeTests
{

    public class SelfPracticeTestCases
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QueriesPermutationsWithKey_Test()
        {
            var q1 = new int[] { 3, 1, 2, 1 };
            var q2 = new int[] { 4, 1, 2, 2 };
            var q3 = new int[] { 7, 5, 5, 8, 3 };
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q1, 5), Is.EqualTo(new int[] { 2, 1, 2, 1 }));
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q2, 4), Is.EqualTo(new int[] { 3, 1, 2, 0 }));
            Assert.That(QueriesPermutationsWithKey.ProcessQueries(q3, 8), Is.EqualTo(new int[] { 6, 5, 0, 7, 5 }));
        }
    }
}