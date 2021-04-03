using System;

namespace Recursive_Factoriel
{
    class Program
    {
        private static int sum = 0;
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveFactoriel(number));
        }

        private static int RecursiveFactoriel(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            return number * RecursiveFactoriel(number - 1);
        }
    }
}
