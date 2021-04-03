using System;
using System.Collections.Generic;
using System.Linq;

namespace TowerOFHanoi
{
    class Program
    {
        private static Stack<int> left;
        private static Stack<int> center = new Stack<int>();
        private static Stack<int> right = new Stack<int>();
        private static int step = 0;
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            left = new Stack<int>(Enumerable.Range(1, count).Reverse());
            PrintTower();
            OrderTower(count, left, center, right);
        }

        private static void OrderTower(int length, Stack<int> left, Stack<int> center, Stack<int> right)
        {
            if (length==1)
            {
                step++;
                //1 Step adding disk to center
                center.Push(left.Pop()); 
                Console.WriteLine($"#{step}");
                PrintTower();
                return;
            }
            //2 Step switching right and center and thus moving disk from center to right
            OrderTower(length - 1, left, right, center); 
            step++;
            //3 Step adding disk to Center
            center.Push(left.Pop()); 
            Console.WriteLine($"#{step}");
            PrintTower();
            //4 step Switching left and right and thus giving oportunity for the center to take right element
            OrderTower(length - 1, right, center, left); 
        }

        private static void PrintTower()
        {
            Console.WriteLine($"Left rod:" + String.Join(',', left.Reverse()));
            Console.WriteLine($"Center rod:" + String.Join(',', center.Reverse()));
            Console.WriteLine($"Right rod:" + String.Join(',', right.Reverse()));
            Console.WriteLine();
        }
    }
}
