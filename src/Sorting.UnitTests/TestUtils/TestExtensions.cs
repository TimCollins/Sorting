using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sorting.UnitTests.TestUtils
{
    internal static class TestExtensions
    {
        /// <summary>
        /// Extension method that checks if two sequences are equal.
        /// </summary>
        /// <param name="actual">The actual sequence i.e. what was returned by some method.</param>
        /// <param name="expected">The expected sequence i.e. what should be returned given known input.</param>
        internal static void AssertSequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        {
            List<T> copy = actual.ToList();

            if (!copy.SequenceEqual(expected))
            {
                Assert.Fail("Expected: " +
                    ",".InsertBetween(expected.Select(x => Convert.ToString(x))) + "; was: " +
                    ",".InsertBetween(copy.Select(x => Convert.ToString(x))));
            }
        }

        //internal static void AssertSequenceEqual<T>(this IEnumerable<T> actual, params T[] expected)
        //{
        //    // Working with a copy means we can look over it more than once.
        //    // We're safe to do that with the array anyway.
        //    List<T> copy = actual.ToList();
        //    bool result = copy.SequenceEqual(expected);
        //    // Looks nicer than Assert.IsTrue or Assert.That, unfortunately.
        //    if (!result)
        //    {
        //        Assert.Fail("Expected: " +
        //            ",".InsertBetween(expected.Select(x => Convert.ToString(x))) + "; was: " +
        //            ",".InsertBetween(copy.Select(x => Convert.ToString(x))));
        //    }
        //}

        internal static string InsertBetween(this string delimiter, IEnumerable<string> items)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string item in items)
            {
                if (builder.Length != 0)
                {
                    builder.Append(delimiter);
                }
                builder.Append(item);
            }
            return builder.ToString();
        }
    }
}
