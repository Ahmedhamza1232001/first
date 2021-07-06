using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)

        {
            

            Student s1 = new Student();
            s1.studentGrades = new Dictionary<string, int>();
            s1.studentGrades.Add(Student.sub1, 20);
            s1.studentGrades.Add(Student.sub2, 30);
            s1.studentGrades.Add(Student.sub3, 40);
            s1.studentGrades.Add(Student.sub4, 50);

            foreach (var item in s1.studentGrades)
            {
                Console.WriteLine( "student1 grades = {0}",item);

            }

            Console.WriteLine();


            Student s2 = new Student();
            s2.studentGrades = new Dictionary<string, int>();
            s2.studentGrades.Add(Student.sub1, 90);
            s2.studentGrades.Add(Student.sub2, 100);
            s2.studentGrades.Add(Student.sub3, 50);
            s2.studentGrades.Add(Student.sub4, 30);

            foreach (var item in s1.studentGrades)
            {
                Console.WriteLine("student2 grades = {0}", item);

            }

            Console.WriteLine();


            Student s3 = new Student();
            s3.studentGrades = new Dictionary<string, int>();
            s3.studentGrades.Add(Student.sub1, 10);
            s3.studentGrades.Add(Student.sub2, 70);
            s3.studentGrades.Add(Student.sub3, 40);
            s3.studentGrades.Add(Student.sub4, 60);

            foreach (var item in s1.studentGrades)
            {
                Console.WriteLine("student3 grades = {0}", item);

            }

            Console.WriteLine();


            Student s4 = new Student();
            s4.studentGrades = new Dictionary<string, int>();
            s4.studentGrades.Add(Student.sub1, 100);
            s4.studentGrades.Add(Student.sub2, 80);
            s4.studentGrades.Add(Student.sub3, 70);
            s4.studentGrades.Add(Student.sub4, 90);

            foreach (var item in s1.studentGrades)
            {
                Console.WriteLine("student4 grades = {0}", item);

            }


            Dictionary<string, int>[] StudentsGrades = new Dictionary<string, int>[]
            {
                s1.studentGrades,
                s2.studentGrades,
                s3.studentGrades,
                s4.studentGrades,
            };
            

            Console.WriteLine("the avrage of subject = {0}", GetAvrage(Student.sub1,StudentsGrades));








            Console.WriteLine("==============================================================================================");

            
            Console.WriteLine("enter the number of students");
            int NubmerOfstudents = Convert.ToInt32(Console.ReadLine());
            for (int student = 1; student < NubmerOfstudents + 1; student++)
            {
                Console.WriteLine("enter the number of courses for the student number {0}",student);
                int NubmerOfCourses = Convert.ToInt32(Console.ReadLine());
                int sum = 0;
                for (int i = 1; i < NubmerOfCourses + 1; i++)
                {
                    Console.WriteLine("enter the   course's grade number {0}", i);
                    sum += Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine("the total grade ={0} ", sum);
            }

            
             
        }

        public static int GetAvrage(string sub, Dictionary<string,int>[]x)
        {
            int sum = 0;
            int avg = 0;
            int i = 0;
            foreach (var item in x)
            {
                sum += x[i][sub];
                i++;
            }
            avg = sum / 4;
            return avg;



        }
    }
    
    public class Student
    {
        public static string sub1 = "Math";
        public static string sub2 = "Electronics";
        public static string sub3 = "Programing";
        public static string sub4 = "Data structure";

        




        public Dictionary<string, int> studentGrades = new Dictionary<string, int>();

       


    }
    
}

