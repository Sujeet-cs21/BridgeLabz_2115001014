using System;
using System.Collections.Generic;

namespace PP_05_02_2025
{
    //Course in the university
    class Course1
    {
        public string CourseName { get; set; }
        public Professor AssignedProfessor { get; private set; }
        public List<Student1> EnrolledStudents { get; } = new List<Student1>();

        public Course1(string courseName)
        {
            CourseName = courseName;
        }

        // Assign a professor to the course
        public void AssignProfessor(Professor professor)
        {
            AssignedProfessor = professor;
        }

        // Enroll a student in the course
        public void EnrollStudent(Student1 student)
        {
            if (!EnrolledStudents.Contains(student))
            {
                EnrolledStudents.Add(student);
                student.EnrollCourse(this); //interact with student
            }
        }

        // Display course details
        public void ShowCourseDetails()
        {
            Console.WriteLine("Course: " + CourseName);
            Console.WriteLine("Professor: " + AssignedProfessor.Name);
            Console.WriteLine("Enrolled Students:");
            foreach (var student in EnrolledStudents)
            {
                Console.WriteLine("- " + student.Name);
            }
            Console.WriteLine("*************************");
        }
    }

    // Student who can enroll in multiple courses
    class Student1
    {
        public string Name { get; set; }
        public List<Course1> Courses { get; } = new List<Course1>();

        public Student1(string name)
        {
            Name = name;
        }

        // Enroll in a course
        public void EnrollCourse(Course1 course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.EnrollStudent(this); //interact with course
            }
        }

        // Display courses enrolled by the student
        public void ShowCourses()
        {
            Console.WriteLine(Name + " is enrolled in the following courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine("*************************");
        }
    }

    //Professor who can teach multiple courses
    class Professor
    {
        public string Name { get; set; }
        public List<Course1> Courses { get; } = new List<Course1>();

        public Professor(string name)
        {
            Name = name;
        }

        // Assign professor to a course
        public void AssignToCourse(Course1 course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
                course.AssignProfessor(this); // interact with course
            }
        }

        // Display courses taught by the professor
        public void ShowCourses()
        {
            Console.WriteLine("Professor " + Name + " teaches the following courses:");
            foreach (var course in Courses)
            {
                Console.WriteLine("- " + course.CourseName);
            }
            Console.WriteLine("*************************");
        }
    }

    //University managing students, professors, and courses
    class University1
    {
        public string UniversityName { get; set; }
        public List<Student1> Students { get; } = new List<Student1>();
        public List<Professor> Professors { get; } = new List<Professor>();
        public List<Course1> Courses { get; } = new List<Course1>();

        public University1(string universityName)
        {
            UniversityName = universityName;
        }

        // Add a student to the university
        public void AddStudent(Student1 student)
        {
            if (!Students.Contains(student))
            {
                Students.Add(student);
            }
        }

        // Add a professor to the university
        public void AddProfessor(Professor professor)
        {
            if (!Professors.Contains(professor))
            {
                Professors.Add(professor);
            }
        }

        // Add a course to the university
        public void AddCourse(Course1 course)
        {
            if (!Courses.Contains(course))
            {
                Courses.Add(course);
            }
        }
    }

    // Main program
    class Class8
    {
        public static void Main8()
        {
            // Create a university instance
            University1 myUniversity = new University1("GLA University");

            // Create professor instances
            Professor professor1 = new Professor("Profesor1");
            Professor professor2 = new Professor("Profesor2");

            // Create student instances
            Student1 student1 = new Student1("Student1");
            Student1 student2 = new Student1("Student2");

            // Create course instances
            Course1 math = new Course1("Mathematics");
            Course1 cs = new Course1("Computer Science");

            // Add professors, students, and courses to the university
            myUniversity.AddProfessor(professor1);
            myUniversity.AddProfessor(professor2);
            myUniversity.AddStudent(student1);
            myUniversity.AddStudent(student2);
            myUniversity.AddCourse(math);
            myUniversity.AddCourse(cs);

            // Assign professors to courses
            professor1.AssignToCourse(math);
            professor2.AssignToCourse(cs);

            // Enroll students in courses
            student1.EnrollCourse(math);
            student2.EnrollCourse(cs);
            student1.EnrollCourse(cs);

            // Display relationships
            math.ShowCourseDetails();
            cs.ShowCourseDetails();

            student1.ShowCourses();
            student2.ShowCourses();

            professor1.ShowCourses();
            professor2.ShowCourses();
        }
    }
}
