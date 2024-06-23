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
            //test case 1
            int[] test_customers_1 = { 1, 2, };
            int[] grumpy_1 = { 1, 0, };
            //test case 2
            int[] test_customers_2 = { 1, 2, 3, 4, 5 };
            int[] grumpy_2 = { 1, 0, 0, 0, 1 };
            //test case 3
            int[] test_customers_3 = { 1, 2, 77 };
            int[] grumpy_3 = { 1, 0, 1 };
            // test case 4
            int[] test_customers_4 = { 1, 2, };
            int[] grumpy_4 = { 1, 0, };
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_1, grumpy_1, 1), Is.EqualTo(3));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_2, grumpy_2, 4), Is.EqualTo(14));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_2, grumpy_2, 5), Is.EqualTo(15));
            Assert.That(GrumpyBoss.MaxSatisfied(test_customers_3, grumpy_3, 1), Is.EqualTo(79));
        }
    }
}