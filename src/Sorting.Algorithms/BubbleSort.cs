using System;

namespace Sorting.Algorithms
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (source.Length == 0 || source.Length == 1)
            {
                return source;
            }

            return source;
        }
    }
}
