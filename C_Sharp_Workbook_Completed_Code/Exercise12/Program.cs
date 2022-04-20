using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingCourse course1 = new TrainingCourse(4);

            course1.SetCourseTitle("C#");
            course1.SetCourseLocation("Teams Meeting");

            //This creates a DateTime object that is 10 days from today's date
            course1.SetCourseDate(DateTime.Now.AddDays(10));

            course1.SetCourseDuration(2);
            course1.SetCourseTrainer("Stuart");

            course1.AddAttendee("Megan");
            course1.AddAttendee("Mark");
            course1.AddAttendee("Molly");
            course1.AddAttendee("Michael");

            // This should result in a message saying the course is full
            course1.AddAttendee("Michelle");

            course1.DisplayEmailMessage();
        }
    }
}
