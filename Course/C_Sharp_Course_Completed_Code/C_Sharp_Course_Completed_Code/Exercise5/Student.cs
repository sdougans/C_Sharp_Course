using System;

namespace Exercise5
{
    /*
     * This is a Class that we have created. It is called Student.
     * In this class, we have defined that a Student has 4 variables to hold specific data, name, subject, examPercentage and whether they are living in housing or not.
     * The class also has some methods to interact with these variables.
     * Notice that there are no values specific to any single student in this class.
     *      Specific values are set when a student object is created in the Main method.
     */
    class Student
    {

        // these are the variables which all student will have. Notice they do not have values yet.
        private string name;
        private string subject;
        private double examPercentage;
        private bool isLivingInHousing;

        // This is a constructor method. It is run when a new Student object is created (in the Main method).
        // When a new student is created, values are passed in as parameters to this constructor, and they are stored in the global variables at the top of this class.
        public Student(string studentName, string studentSubject, double studentExamPercentage, bool isStudentLivingInHousing)
        {
            name = studentName;
            subject = studentSubject;
            examPercentage = studentExamPercentage;
            isLivingInHousing = isStudentLivingInHousing;
        }

        // This is a method which will print all of the details of the student to the console.
        // It makes various method calls to other methods, also contained in this class.
        public void PrintStudentDetails()
        {
            Console.WriteLine("\n## These are the details of the student ##");
            PrintStudentName();
            PrintStudentSubject();
            PrintStudentExamPercentage();
            PrintStudentLivingInHousing();
            Console.WriteLine("## ------------------------------------ ##\n");
        }

        // These 4 methods print the value of the variables defined at the top of this class.
        public void PrintStudentName()
        {
            Console.WriteLine("Name: " + name);
        }
        public void PrintStudentSubject()
        {
            Console.WriteLine("Subject: " + subject);
        }
        public void PrintStudentExamPercentage()
        {
            Console.WriteLine("Exam Percentage: " + examPercentage);
        }
        public void PrintStudentLivingInHousing()
        {
            // this method uses some logic to print out a meaningful method to the user, instead of just printing the value true/false.
            if (isLivingInHousing)
            {
                Console.WriteLine("This student is living in student housing");
            }
            else
            {
                Console.WriteLine("This student is not living in student housing");
            }
        }

        // This method uses logic to work out a students final grade, using their examPercentage.
        // It returns a single character, representing their final grade.
        public char CalculateFinalGrade()
        {
            if (examPercentage >= 75)
            {
                return 'A';
            }

            if (examPercentage >= 60)
            {
                return 'B';
            }

            if (examPercentage >= 50)
            {
                return 'C';
            }

            if (examPercentage >= 40)
            {
                return 'D';
            }

            return 'F';


        }

    }
}
