using System;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ann", "Bob", "Chip", "Dee", "Erin", "Frank" };
            int[] scores = { 81, 65, 52, 45, 28, 24 };

            CalculateStudentGrades(names, scores);
        }

        public static void CalculateStudentGrades(string[] names, int[] scores)
        {
            int lengthOfNames = names.Length;

            // Loop through the list of names
            for(int i=0; i<lengthOfNames; i++)
            {
                // On each iteration, store the current name, current score, and work out the grade for the current student
                string currentName = names[i];
                int currentScore = scores[i];
                char grade = CalculateIndividualGrade(currentScore);

                Console.WriteLine(currentName + " got grade " + grade);
            }
        }

        public static char CalculateIndividualGrade(int score)
        {
            if(score > 80)
            {
                return 'A';
            }
            if (score > 60)
            {
                return 'B';
            }
            if (score > 50)
            {
                return 'C';
            }
            if (score > 44)
            {
                return 'D';
            }
            if (score > 24)
            {
                return 'E';
            }

            return 'F';
        }
    }
}
