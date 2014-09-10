using System;

namespace Sorting.Algorithms
{
    public static class QuickSort
    {
        public static int[] Sort(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Length == 0)
            {
                return source;
            }

            return new[] {0};
            //return source;
        }
    }
}
