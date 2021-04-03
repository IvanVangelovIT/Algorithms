﻿using System;
using System.Linq;

namespace SortingAlgorithms
{
    /// <summary>
    /// Time Complexity: O(n^2). Two nested loops; 
    /// In the second iteration we are searching for min element and when we find it
    /// we swap with the element from the first iteration
    /// </summary>
    class SelectionSort
    {
        public static int[] arr;
        static void Main(string[] args)
         {
            Console.WriteLine("Enter numbers separated by space");
            arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SelectionSortMethod(arr);
        }

        private static void SelectionSortMethod(int[] arr)
        {
            int length = arr.Length;
            //First Iteartion
            for (int i = 0; i < length; i++)
            {
                int minIndex = i;

                //Second Iteration
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                     SwapElements(i, minIndex);
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
