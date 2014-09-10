using System;
using NUnit.Framework;
using Sorting.UnitTests.TestUtils;

namespace Sorting.UnitTests
{
    [TestFixture]
    public class QuickSortTests
    {
        [Test]
        public void NullSourceThrowsException()
        {
            int[] source = null;

            Assert.Throws<ArgumentNullException>(() => Algorithms.QuickSort.Sort(source));
        }

        [Test]
        public void EmptySourceReturnsEmptyResult()
        {
            int[] source = { };
            var result = Algorithms.QuickSort.Sort(source);

            Assert.AreEqual(source, result);
        }

        [Test]
        public void SingleElementSourceReturnsSingleElement()
        {
            int[] source = { 2 };

            var result = Algorithms.QuickSort.Sort(source);

            Assert.AreEqual(source, result);
        }

        //[Test]
        //public void VerifyShortSequence()
        //{
        //    int[] source = { 2, 1, 3 };
        //    int[] result = Algorithms.QuickSort.Sort(source);

        //    result.AssertSequenceEqual(1, 2, 3);
        //}
    }
}
