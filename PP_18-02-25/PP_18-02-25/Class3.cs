using System;
using System.Collections.Generic;

namespace PP_18_02_25
{
    // Abstract Class CourseType
    public abstract class CourseType
    {
        public string TypeName { get; set; }
    }

    // Specific Course Types
    public class ExamCourse : CourseType
    {
        public ExamCourse() { TypeName = "Exam-Based Course"; }
    }

    public class AssignmentCourse : CourseType
    {
        public AssignmentCourse() { TypeName = "Assignment-Based Course"; }
    }

    // Interface for Course
    public interface ICourse
    {
        void DisplayCourse();
    }

    // Generic Course Class Implementing ICourse
    public class Course<T> : ICourse where T : CourseType
    {
        public string CourseName { get; set; }
        public string Department { get; set; }
        public T EvaluationType { get; set; }

        public Course(string courseName, string department, T evaluationType)
        {
            CourseName = courseName;
            Department = department;
            EvaluationType = evaluationType;
        }

        public void DisplayCourse()
        {
            Console.WriteLine("Course: " + CourseName + ", Department: " + Department + ", Evaluation: " + EvaluationType.TypeName);
        }
    }

    // University Class to Manage Courses
    public class University
    {
        private List<ICourse> courses = new List<ICourse>();

        // Add Courses Dynamically
        public void AddCourse<T>(Course<T> course) where T : CourseType
        {
            courses.Add(course);
        }

        // Display All Courses
        public void DisplayAllCourses()
        {
            Console.WriteLine("\n--- University Courses ---");
            foreach (var course in courses)
            {
                course.DisplayCourse();
            }
        }
    }

    // Main Program
    class Class3
    {
        public static void Main3()
        {
            // Create Course Types
            ExamCourse examType = new ExamCourse();
            AssignmentCourse assignmentType = new AssignmentCourse();

            // Create Courses
            Course<ExamCourse> mathCourse = new Course<ExamCourse>("Calculus", "Mathematics", examType);
            Course<AssignmentCourse> historyCourse = new Course<AssignmentCourse>("World History", "Humanities", assignmentType);

            // University System
            University university = new University();
            university.AddCourse(mathCourse);
            university.AddCourse(historyCourse);

            // Display Courses
            university.DisplayAllCourses();
        }
    }

}
