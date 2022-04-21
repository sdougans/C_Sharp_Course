using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            // These lines of code are method call, which tell the program to execute the method named Print()
            // The Print method expects a single parameter, so we need to supply this when we make the method call
            // the method can be reused multiple times, using different values each time
            Print("Hello, world!");
            Print("My name is Simon");
            Print("I love C# !!");

            // These lines make method calls to the GetBiggest() method, and print the value that is returned from this method.
            // The GetBiggest() method expects 3 integer parameters, so we need to supply these when the method call is made.
            Console.WriteLine(GetBiggest(1, 2, 10));
            Console.WriteLine(GetBiggest(-11, 50, 49));
            Console.WriteLine(GetBiggest(-2, -3, -1));
            Console.WriteLine(GetBiggest(2, 2, 2));

            // these lines of code make a call to the FizzBuzz() method
            // the FizzBuzz() method expects a single integer parameter, so we need to supply this as well.
            FizzBuzz(101);
            FizzBuzz(314);
        }

        /*
         * this is a method we have created which will print some text to the console.
         * It has a return type of 'void', meaning no value is returned from this method
         * The method has a single string parameter, the value of which will be printed using the WriteLine() method.
         */
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }

        /*
         * this is a method which will work out the largest of 3 given numbers, and return the result.
         * The method has a return type of int, meaning it will return an integer value.
         * The method has 3 integer parameters.
         * The return keyword is used to return the value from this method back to the code that made the method call.
         */
        public static int GetBiggest(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }
            if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }

            return num3;
        }

        /*
         * this method will execute the FizzBuzz exercise.
         * It expects a single integer parameter which is used in the condition statement in the loop.
         * It uses a For Loop to repeat lines of code, and a series of If statements to perform the logical comparisons.
         */
        public static void FizzBuzz(int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
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
