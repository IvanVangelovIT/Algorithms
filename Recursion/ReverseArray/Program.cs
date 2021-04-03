using System;
using System.Linq;

namespace ReverseArray
{
    class Program
    {
        private static int[] arr;
        static void Main(string[] args)
        {
            arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            ReverseArray(0, arr.Length - 1);

        }

        private static void Print()
        {
            Console.WriteLine(String.Join(' ', arr));
        }

        private static void ReverseArray(int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                Print();
                return;
            }
            SwapArray(startIndex, endIndex);
            ReverseArray(startIndex + 1, endIndex - 1);
        }

        private static void SwapArray(int startIndex, int endIndex)
        {
            int temp = arr[startIndex];
            arr[startIndex] = arr[endIndex];
            arr[endIndex] = temp;
        }
    }
}
