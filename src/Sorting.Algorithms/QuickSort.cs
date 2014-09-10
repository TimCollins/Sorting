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

            // Pick an element, called a pivot, from the array.
            int pivot = source[0];

            // Reorder the array so that all elements with values less than the pivot 
            // come before the pivot, while all elements with values greater than the 
            // pivot come after it (equal values can go either way). 
            for (int i = 0; i < source.Length; i++)
            {
                
            }

            // After this partitioning, the pivot is in its final position. 
            // This is called the partition operation.
// Recursively apply the above steps to the sub-array of elements with smaller values and separately to the sub-array of elements with greater values.


            return source;
        }
    }
}
