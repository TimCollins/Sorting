using System;
using NUnit.Framework;
using Sorting.Algorithms;
using Sorting.UnitTests.TestUtils;

namespace Sorting.UnitTests
{
    class BubbleSortTests
    {
        [Test]
        public void NullSourceThrowsException()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => Algorithms.BubbleSort.Sort(source));
        }

        [Test]
        public void EmptySourceReturnsEmptyResult()
        {
            int[] source = { };
            var result = BubbleSort.Sort(source);

            Assert.AreEqual(source, result);
        }

        [Test]
        public void SingleElementSourceReturnsSingleElement()
        {
            int[] source = { 2 };

            var result = BubbleSort.Sort(source);

            Assert.AreEqual(source, result);
        }

        [Test]
        public void TestImplementation()
        {
            int[] source = {5, 1, 4, 2, 8};
            int[] result = BubbleSort.Sort(source);

            result.AssertSequenceEqual(1, 2, 4, 5, 8);
        }
    }
}
