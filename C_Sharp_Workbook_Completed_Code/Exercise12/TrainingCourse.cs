using System;

namespace Exercise12
{
    class TrainingCourse
    {
        int maxAttendees;

        string courseTitle;
        string courseLocation;
        DateTime courseDate;
        string courseTrainer;
        int courseDuration;

        string[] attendeeList;

        public TrainingCourse(int maxAttendees)
        {
            this.maxAttendees = maxAttendees;
            attendeeList = new string[maxAttendees];
        }

        public void SetCourseTitle(string title)
        {
            courseTitle = title;
        }
        public void SetCourseLocation(string location)
        {
            courseLocation = location;
        }
        public void SetCourseDate(DateTime date)
        {
            courseDate = date;
        }
        public void SetCourseTrainer(string trainer)
        {
            courseTrainer = trainer;
        }
        public void SetCourseDuration(int duration)
        {
            courseDuration = duration;
        }

        public void AddAttendee(string name)
        {
            bool isStudentAdded = false;

            for (int i = 0; i < maxAttendees; i++)
            {
                // If no name has been added yet, the value of attendeeList[i] will be null, if the position is null, we can enter the new students name
                if (attendeeList[i] == null)
                {
                    attendeeList[i] = name;
                    isStudentAdded = true;
                    break;
                }
            }

            if (isStudentAdded)
            {
                Console.WriteLine("Student added to the course!");
            }
            else
            {
                Console.WriteLine("The course is full!");
            }
        }

        public void DisplayEmailMessage()
        {
            string allAttendees = string.Join(", ", attendeeList);

            Console.WriteLine("Dear " + courseTrainer + ", the upcoming " + courseTitle + " course will be held at " + courseLocation + " on " + courseDate + ".");
            Console.WriteLine("The following " + attendeeList.Length + " people will be in attendence: " + allAttendees);
            Console.WriteLine("The course is expected to run for " + courseDuration + " day(s)");
        }

    }
}
