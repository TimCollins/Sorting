using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms");
            Console.WriteLine("QuickSort.\n");

            Console.WriteLine("Input");
            int[] source = {2, 1, 3};
            ObjectDumper.Write(source);

            Console.WriteLine("\nOutput");
            var output = Sorting.Algorithms.QuickSort.Sort(source);
            ObjectDumper.Write(output);

            Util.WaitForEscape();
        }
    }
}
