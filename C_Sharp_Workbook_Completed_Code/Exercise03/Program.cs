using System;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            // These 2 lines crate integer arrays
            int[] array1 = { 3, 6, 4, 3, 2 };
            int[] array2 = { 3, 6, 4, 3, 2, 2, 3, 5, 6, 1, 7 };

            // These two lines call the FindSmallestNumberInArray() method and print the result to the console.
            Console.WriteLine("The smallest number in the array { 3, 6, 4, 3, 2 } is " + FindSmallestNumberInArray(array1));
            Console.WriteLine("The smallest number in the array { 3, 6, 4, 3, 2, 2, 3, 5, 6, 1, 7 } is " + FindSmallestNumberInArray(array2));

        }


        /*
         * This method accepts an integer array as a parameter
         * The method will loop through the array to find the smallest number
         * The smallest number will be returned
         */

        public static int FindSmallestNumberInArray(int[] integerArray)
        {
            // Find the length of the array so we know how many times to run the loop
            int lengthOfArray = integerArray.Length;

            // Set the smallest number initially to be the first number in the array
            int smallestNumber = integerArray[0];

            // Loop through the array from index 1 to index lengthOfArray-1
            for (int i = 1; i < lengthOfArray; i++)
            {
                // If the value at the current index is smaller than smallestNumber, then update smallestNumber
                if (integerArray[i] < smallestNumber)
                {
                    smallestNumber = integerArray[i];
                }
            }

            // Once the loop has finished, return the smallest number
            return smallestNumber;
        }
    }
}
