using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            GeneratePassword("Johnson", "Stephen");
        }

        public static void GeneratePassword(string firstName, string lastName)
        {
            // This code will return a random 3 digit number, between 100 (inclusive) and 1000 (exclusive)
            int randomNumber = new Random().Next(100, 1000);

            Console.WriteLine("First name is " + firstName);
            Console.WriteLine("Last name is " + lastName );
            Console.WriteLine("Random number is " + randomNumber);

            // The substring method will return a new string starting from the first potition (zero) to the 4th position of the supplied string
            // e.g. Substring(0, 2) of the string "John" is "Jo"

            // The ToUpper() method converts the string to uppercase
            string lastNameModified = lastName.Substring(0, 4).ToUpper();
            string firstNameModified = firstName.Substring(0, 1).ToUpper();

            string password = lastNameModified + firstNameModified + randomNumber;
            Console.WriteLine("Generated password is: " + password);
        }
    }
}
