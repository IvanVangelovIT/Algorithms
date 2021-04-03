using System;
using System.Linq;

namespace BubbleSort
{
    class BubbleSort
    {
        public static int[] arr;

        /// <summary>
        /// Time complexity O(n^2)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by space");
            arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            BubbleSortMethod(arr);
        }

        private static void BubbleSortMethod(int[] arr)
        {
            int length = arr.Length;
            //First Iteartion
            for (int i = 0; i < length; i++)
            {
                //Second Iteration
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        SwapElements(i, j);
                    }
                }
            }

            PrintArray();
        }

        private static void PrintArray()
        {
            Console.WriteLine("Sorted Array");
            arr.ToList().ForEach(e => Console.Write(e + " "));
        }

        private static void SwapElements(int firstElement, int secondElement)
        {
            int temp = arr[firstElement];
            arr[firstElement] = arr[secondElement];
            arr[secondElement] = temp;
        }
    }
}
