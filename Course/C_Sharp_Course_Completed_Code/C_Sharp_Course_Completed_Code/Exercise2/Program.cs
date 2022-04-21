using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * These are variable declarations.
             * When declaring variables you need to put the data type that variable will hold, and the name of the variable.
             * Using the equals '=' operator, you can set the variable value.
             *
             * Remember:
             *      single characters require single quotes 'A'.
             *      strings of text require double quotes "I am a string of text".
             *      numbers, integers or decimals, do not require any quotations.
             *      boolean values are either true or false. 
             */
            string name = "Sam";
            string subject = "History";
            int duration = 4;
            double examResult = 78.5;
            char grade = 'A';
            bool isLivingInResidence = true;


            // In these lines of code, concatenation is used to join text together into a new variable which are then printed out below.
            string sentence1 = "My name is " + name + ", and I am a student studying a " + duration + "-year course in " + subject + ".";
            string sentence2 = "I have an exam average of " + examResult + "% which means I am on track to get a grade " + grade + ".";
            Console.WriteLine(sentence1);
            Console.WriteLine(sentence2);




            int w = 3;
            int x = 4;
            int y = 6;
            int z = -2;

            // You can use mathematical operators [ + add, - subtract, * multiply, / divide ] to perform calculations on numerical variables
            int sum = w + x + y + z;
            int product = w * x * y * z;
            int average = product / 4;

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The product is: " + product);
            Console.WriteLine("The average is: " + average);


            // This is an array. Arrays can hold multiple values. They are declared using square brackets after the data type.
            string[] racePositions = { "1st - Sue", "4th - Paul", "3rd - Dave", "5th - Amy", "2nd - Mark"};

            // To access a particular item in the array, you need to provide an index representing a position in the array.
            // Remember that array indexes start from 0 (zero)
            Console.WriteLine(racePositions[0]);
            Console.WriteLine(racePositions[4]);
            Console.WriteLine(racePositions[2]);
            Console.WriteLine(racePositions[1]);
            Console.WriteLine(racePositions[3]);



            // Bonus - this is more advanced than an introductory course

            // these lines of code print out some text to the user asking them for the race position of each runner.
            Console.WriteLine("Enter the race position for Sue: ");
            
            // these lines of code store the users input along with the name of the runner
            string racePosition1 = Console.ReadLine() + " - Sue";
            
            // repeat for all runners
            Console.WriteLine("Enter the race position for Paul: ");
            string racePosition2 = Console.ReadLine() + " - Paul";
            Console.WriteLine("Enter the race position for Dave: ");
            string racePosition3 = Console.ReadLine() + " - Dave";
            Console.WriteLine("Enter the race position for Amy: ");
            string racePosition4 = Console.ReadLine() + " - Amy";
            Console.WriteLine("Enter the race position for Mark: ");
            string racePosition5 = Console.ReadLine() + " - Mark";

            // store the runner positions in an array
            string[] bonusRacePositions = { racePosition1, racePosition2, racePosition3, racePosition4, racePosition5};
            
            // this is a method that will sort the array alphanumerically (in order of number first, then alphabetically)
            Array.Sort(bonusRacePositions);

            // these lines print the race results to the console
            Console.WriteLine();
            Console.WriteLine("The final race positions in order are:");
            Console.WriteLine(bonusRacePositions[0]);
            Console.WriteLine(bonusRacePositions[1]);
            Console.WriteLine(bonusRacePositions[2]);
            Console.WriteLine(bonusRacePositions[3]);
            Console.WriteLine(bonusRacePositions[4]);

        }
    }
}
