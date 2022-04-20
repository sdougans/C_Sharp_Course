using System;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 99;
            int y = -11;
            int z = 2;

            // Solution 1
            Console.WriteLine("The smallest of " + x + ", " + y + ", " + z + " is: " + GetSmallestNumber(x, y, z));

            // Solution 2
            Console.WriteLine("The smallest of " + x + ", " + y + ", " + z + " is: " + GetSmallestOfThreeNumbers(x, y, z));
        }

        // Solution 1
        /*
         * This solution usies a series of If statements to find the smallest of 3 numbers
         */
        public static int GetSmallestNumber(int num1, int num2, int num3)
        {
            // If num1 is smaller than (or equal to) both num2 and num3, then return num1
            if (num1 <= num2 && num1 <= num3)
            {
                return num1;
            }

            // If num2 is smaller than (or equal to) both num1 and num3, then return num2
            if (num2 <= num1 && num2 <= num3)
            {
                return num2;
            }

            // Otherwise, return num3
            return num3;
        }



        // Solution 2

        /*
         * This solution uses fewer if statements, and instead simplifies the solution to first find the smallest of 2 numbers
         * then compare that number to the third number to find the overall smallest.
         */
        public static int GetSmallestOfThreeNumbers(int num1, int num2, int num3)
        {
            int smallestOfFirstTwo = GetSmallestOfTwoNumbers(num1, num2);
            int smallest = GetSmallestOfTwoNumbers(smallestOfFirstTwo, num3);

            return smallest;
        }

        public static int GetSmallestOfTwoNumbers(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }

            return num2;
        }
    }
}
