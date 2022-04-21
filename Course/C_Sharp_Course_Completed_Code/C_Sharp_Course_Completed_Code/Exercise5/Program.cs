using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * These lines of code create an object from the Student class.
             * On each line, a new object is initialized (created), and the variables are set for that srudent.
             * From then on, to interact with a specific student, you can use the objects student1, student2, student3 etc...
             */
            Student student1 = new Student("Simon", "History", 25, true);
            Student student2 = new Student("Mary", "Maths", 40, false);
            Student student3 = new Student("Amy", "English", 59, true);
            Student student4 = new Student("Lisa", "Chemistry", 70, false);
            Student student5 = new Student("Cameron", "Biology", 82, true);

            /*
             * These lines of code use the student objects, and make a call to the PrintStudentDetails() method.
             * This method is defined in the student class, and is therefore available to all student objects that you created above.
             */
            student1.PrintStudentDetails();
            student2.PrintStudentDetails();
            student3.PrintStudentDetails();
            student4.PrintStudentDetails();
            student5.PrintStudentDetails();

            /*
             * These lines of code make a call to the CalculateFinalGrade() method for each student object.
             * The method will work out the student final grade, using the exam grade for that specific student
             */
            Console.WriteLine("Student1's grade is: " + student1.CalculateFinalGrade());
            Console.WriteLine("Student2's grade is: " + student2.CalculateFinalGrade());
            Console.WriteLine("Student3's grade is: " + student3.CalculateFinalGrade());
            Console.WriteLine("Student4's grade is: " + student4.CalculateFinalGrade());
            Console.WriteLine("Student5's grade is: " + student5.CalculateFinalGrade());

        }
    }
}
