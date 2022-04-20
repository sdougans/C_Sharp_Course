using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFibonacciSequence(10);
        }

        public static void PrintFibonacciSequence(int n)
        {
            /*
             * Fibonacci sequence starts with 0 (zero)
             * Using Console.Write() instead of Console.WriteLine() means all output will be displayed on the same line in the console.
             */
            Console.Write("0 ");

            /*
             * These two variables represent the 2 numbers before the number we are trying to calculate
             * e.g. current number = (n-1)+(n-2)
             */
            int oneNumberBefore = 0;
            int twoNumbersBefore = 1;

            // This loop will repeat as many times as the number n which is passed in as a parameter
            for (int i = 0; i < n; i++)
            {
                /*
                 * This code starts by working out the next number, by adding the 2 previous numbers together
                 * It then updates the 2 previous numbers ready for the next calculation in the next loop
                 */
                int nextNumber = oneNumberBefore + twoNumbersBefore;
                twoNumbersBefore = oneNumberBefore;
                oneNumberBefore = nextNumber;

                Console.Write(nextNumber + " "); ;
            }

        }
    }
}
