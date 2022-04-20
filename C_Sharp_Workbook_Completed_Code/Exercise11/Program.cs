using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            int factorial = CalculateFactorial(number);
            Console.WriteLine(number + "! equals " + factorial);

            number = 6;
            factorial = CalculateFactorial(number);
            Console.WriteLine(number + "! equals " + factorial);

            number = 10;
            factorial = CalculateFactorial(number);
            Console.WriteLine(number + "! equals " + factorial);
        }

        /*
         * This method shows an example of Recursion.
         * Recursion is a method where you call the method from inside the method.
         * 
         * This method will create a chain of calculations, that will only complete once n is equal to the value 1;
         * 
         * e.g. 
         * CalculateFactorial(n) will multiply n by the answer to CalculateFactorial(n-1)
         * CalculateFactorial(n-1) will multiply n-1 by the answer to CalculateFactorial(n-1-1) i.e. (n-2)
         * CalculateFactorial(n-2) will multiply n-2 by the answer to CalculateFactorial(n-3)
         * This process repeats until n is equal to 1, where the calculations can complete and filter back up the chain.
         */
        public static int CalculateFactorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
