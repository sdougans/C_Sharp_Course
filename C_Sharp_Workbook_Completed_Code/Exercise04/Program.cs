using System;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line of code is used to separate the output in the console to make it easier to read
            Console.WriteLine("########################################");
            PrintMultiplicationTable(6);
            Console.WriteLine("########################################");
            PrintMultiplicationTable(12);
            Console.WriteLine("########################################");
        }


        public static void PrintMultiplicationTable(int number)
        {
            /*
             * This is a for loop that will run 12 times (i<13)
             * On each iteration it will print out the value of i * the number parameter that is passed in to this method
             */

            for(int i=1; i<13; i++)
            {
                Console.WriteLine(i + " times " + number + " is " + i*number);
            }
        }
    }
}
