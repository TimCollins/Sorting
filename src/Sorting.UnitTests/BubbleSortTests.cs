using System;
using NUnit.Framework;

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
            var result = Algorithms.BubbleSort.Sort(source);

            Assert.AreEqual(source, result);
        }

        [Test]
        public void SingleElementSourceReturnsSingleElement()
        {
            int[] source = { 2 };

            var result = Algorithms.BubbleSort.Sort(source);

            Assert.AreEqual(source, result);
        }
    }
}
