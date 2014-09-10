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

            if (source.Length == 0 || source.Length == 1)
            {
                return source;
            }

            //QuickSortImpl(source, 0, source.Length - 1);

            return source;
        }

        private static void QuickSortImpl(int[] source, int leftIndex, int rightIndex)
        {

        }
    }
}
