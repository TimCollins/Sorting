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

            return BubbleSortImpl(source);
        }

        private static int[] BubbleSortImpl(int[] source)
        {
            int i = source.Length - 1;

            while (i > 0)
            {
                int swap = 0;
                for (int j = 0; j < i; j++)
                {
                    if (source[j + 1] < source[j])
                    {
                        int tmp = source[j + 1];
                        source[j + 1] = source[j];
                        source[j] = tmp;
                        swap = j;
                    }
                }

                i = swap;
            }

            return source;
        }
    }
}
