using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class ComputingClass
    {
        private string className;
        private string teacherName;
        Student[] students;

        public ComputingClass(string c, string t)
        {
            className = c;
            teacherName = t;
        }

        public void AssignStudents(int size)
        {
            students = new Student[size];
            string forename;
            string surname;
            string predGrade;
            string grade;
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write("Enter Forename: ");
                forename = Console.ReadLine();
                Console.Write("Enter Surname: ");
                surname = Console.ReadLine();
                Console.Write("Enter Predicted Grade: ");
                predGrade = Console.ReadLine();
                Console.Write("Enter Grade: ");
                grade = Console.ReadLine();
                students[i] = new Student(forename, surname, predGrade, grade);
            }
        }

        public int TotalClassValueAdded()
        {
            int total = 0;
            for (int i = 0; i < students.Length; i++)
            {
                total = total + students[i].CalculateVA();
            }

            return total;
        }

        public int AverageValueAdded()
        {
            int total = TotalClassValueAdded();
            int averageVA = total / students.Length;

            return averageVA;
        }

    }
}
