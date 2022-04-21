using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            // set 3 integer variables and print them to the console
            int num1 = 1;
            int num2 = 5;
            int num3 = 10;
            Console.WriteLine("Number 1 is: " + num1);
            Console.WriteLine("Number 2 is: " + num2);
            Console.WriteLine("Number 3 is: " + num3);

            // set a variable which will eventually hold the largest number
            int largest;

            // this logic will run to work out which of the 3 numbers is largest

            // if num1 is greater than or equal to num2 and num1 is greater than or equal to num3, then num1 is the largest number
            if (num1 >= num2 && num1>=num3)
            {
                largest = num1;
            }
            // if num2 is greater than or equal to num1 and num2 is greater than or equal to num3, then num2 is the largest number
            else if (num2 >= num1 && num2>=num3)
            {
                largest = num2;
            }
            // no other condition check is needed, if the first 2 if statements are false, then num3 must be the largest number
            else
            {
                largest = num3;
            }

            Console.WriteLine("The largest number is: " + largest);




            /*
             * This is a for loop which will repeat the code inside it a certain number of times.
             *      int i=0 sets a counter variable starting from 0
             *      i < 101 is a condition that must be true for the loop to repeat itself
             *      i++ is shorthand for i=i+1. This code is executed at the end of each loop to add 1 to the counter variable i.
             *          This is how we control the number of times the loop repeats itself.
             */

            for (int i = 0; i < 101; i++)
            {
                /*
                 * This logic will work out whether the current value of the counter i is divisible by 5, 3, both 5 and 3, or neither 5 or 3.
                 *
                 * if i%5==0, then we know that i is divisible by 5. The % symbol is known as the modulus function which returns the remainder when 2 numbers are divided
                 *      e.g. 10%5 is 0 because 10 is divisible by 5 and gives no remainder
                 *           11%5 is 1 because 11 is not divisible by 5, and would give a remainder of 1.
                 */
                if ((i % 5 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ((i % 3 == 0))
                {
                    Console.WriteLine("Fizz");
                }
                else if ((i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
