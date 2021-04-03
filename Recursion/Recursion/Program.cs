using System;

namespace Recursion
{
    class Program
    {
        /// <summary>
        /// Generating all posible combinations
        /// </summary>
        /// <param name="args"></param>
        /// 

        private static int[] arr;
        static void Main(string[] args)
        {
            Console.WriteLine("Choose length");
            int length = int.Parse(Console.ReadLine());
            arr = new int[length];
            GenerateCombinationsWithRepetition(length, 0);

        }

        private static void GenerateCombinationsWithRepetition(int length, int currentIndex)
        {
            if (length == currentIndex )
            {
                PrintArr();
                return;
            }

            for (int i = 0; i <= length; i++)
            {
                arr[currentIndex] = i;
                GenerateCombinationsWithRepetition(length, currentIndex + 1);
            }
        }

        private static void PrintArr()
        {
            Console.WriteLine(String.Join(' ', arr));
        }
    }
}
