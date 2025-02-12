﻿using System;

namespace PP_11_02_25
{
    //class to store student details
    class Student
    {
        //student details
        public int RollNo;
        public string Name;
        public int Age;
        public string Grade;

        public Student next;

        //constructor to initialize student details
        public Student(int rollNo, string name, int age, string grade)
        {
            RollNo = rollNo;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }

    //class to perform operations on student details
    class Class1
    {
        //head of the student list
        private Student head;

        //method to add student at the beginning of the list
        public  Student AddStudentAtBegining(int rollNo, string name,int age, string grade)
        {
            Student newStudent = new Student(rollNo, name, age, grade);

            if (head == null)
                head = newStudent;
            else
            {
                newStudent.next=head;
                head = newStudent;
            }
            return head;
        }

        //method to add student at the end of the list
        public Student AddStudentInEnd(int rollNo, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNo, name, age, grade);
            Student temp=head;

            if (head == null)
                head = newStudent;
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next=newStudent;
            }
            return head;
        }

        //method to add student at the given position in the list
        public Student AddStudentAtGivenPosition(int rollNo, string name, int age, string grade,int position)
        {
            Student newStudent = new Student(rollNo, name, age, grade);
            Student temp=head;
            Student tmp=head;

            int len = 0;
            while (temp != null)
            {
                len++;
                temp = temp.next;
            }
            if (position > len+1 || position < 0)
                Console.WriteLine("Enter valid position");
            else
            {
                if (position == 1)
                    AddStudentAtBegining(rollNo, name, age, grade);
                position--;
                while (position>1)
                {
                    tmp = tmp.next;
                    position--;
                }
                newStudent.next=tmp.next;
                tmp.next=newStudent;
            }
            return head;
        }

        //method to search student in the list
        public Student SearchStudent(int rollNo)
        {
            if(head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            Student temp = head;
            int count = 0;
            while(temp != null)
            {
                count++;
                if(temp.RollNo==rollNo)
                {
                    Console.WriteLine("sutudent found at "+count+" position");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to delete student from the list
        public Student DeleteStudent(int rollNo)
        {
            if (head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            Student temp = head;
            int count = 0;
            while (temp.next != null)
            {
                count++;
                if (temp.next.RollNo == rollNo)
                {
                    temp.next=temp.next.next;
                    Console.WriteLine("sutudent deleted ");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to update student grade in the list
        public Student UpdateStudent(int rollNo,string grade)
        {
            if (head == null)
            {
                Console.WriteLine("no record found");
                return null;
            }
            Student temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                if (temp.RollNo == rollNo)
                {
                    temp.Grade = grade;
                    Console.WriteLine("sutudent grade has been updated ");
                    return head;
                }
                temp = temp.next;
            }
            Console.WriteLine("Student not found");
            return head;
        }

        //method to display student list
        void Display()
        {
            Student temp = head;
            while (temp != null)
            {
                Console.Write("["+temp.Name+"]->");
                temp = temp.next;
            }
            Console.WriteLine("[null]");
            Console.WriteLine("********************");
        }

        //main method to test the class
        public static void Main1()
        {
            

            Class1 obj=new Class1();

            obj.AddStudentAtBegining(02, "Student2", 16, "A");
            obj.Display();
            obj.AddStudentAtBegining(01, "Student1", 15, "A+");
            obj.Display();
            obj.AddStudentInEnd(04,"Stuent4",14,"A");
            obj.Display() ;
            obj.AddStudentInEnd(06, "Stuent6", 14, "B");
            obj.Display() ;
            obj.AddStudentAtGivenPosition(03,"Student3",17,"A",3);
            obj.Display() ;
            obj.AddStudentAtGivenPosition(05, "Student5", 17, "C", 5);
            obj.Display() ;
            obj.SearchStudent(06);
            obj.DeleteStudent(03);
            obj.Display();
            obj.UpdateStudent(02,"A+");

        }
    }
}
