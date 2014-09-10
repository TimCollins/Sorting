using System.Collections.Generic;
using NUnit.Framework;

namespace Sorting.UnitTests.TestUtils
{
    /// <summary>
    /// Tests for the TestExtensions operations
    /// </summary>
    [TestFixture]
    class TestExtensionsTests
    {
        [Test]
        public void VerifyAssertSequenceEqualSupportsInts()
        {
            int[] source = { 2, 1, 3 };

            source.AssertSequenceEqual(2, 1, 3);
        }

        [Test]
        public void VerifyAssertSequenceEqualSupportsStrings()
        {
            string[] source = {"one", "two", "three"};

            source.AssertSequenceEqual("one", "two", "three");
        }

        [Test]
        public void VerifyAssertSequenceEqualSupportsDecimals()
        {
            decimal[] source = {1.0M, 2.0M};

            source.AssertSequenceEqual(1.0M, 2.0M);
        }

        [Test]
        public void VerifyAssertSequenceEqualSupportsLists()
        {
            List<int> source = new List<int> {2, 1, 3};

            source.AssertSequenceEqual(2, 1, 3);
        }

        [Test]
        public void VerifyAssertSequenceEqualActuallyDoesVerification()
        {
            int[] source = { 2, 1, 3 };



            source.AssertSequenceEqual(2, 1, 3);
        }
    }
}
