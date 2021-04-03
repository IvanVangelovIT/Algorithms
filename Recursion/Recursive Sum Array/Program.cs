using System;
using System.Linq;

namespace Recursive_Sum_Array
{
    class Program
    {
        private static int[] arr;
        static void Main(string[] args)
        {
            CreateArray();
            int sum = RecursiveSumArray(arr, 0);
            PrintArraySum(sum);
        }

        private static void PrintArraySum(int sum)
        {
            Console.WriteLine(sum);
        }

        private static int RecursiveSumArray(int[] arr, int index)
        {
            if (arr.Length == index)
            {
                return 0;
            }

            return arr[index] + RecursiveSumArray(arr, index + 1);
        }

        private static void CreateArray()
        {
            arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }
    }
}
