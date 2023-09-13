using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class ComputingClass
    {
        private static string className;
        private Student[] students;

        public ComputingClass(string c)
        {
            className = c;
        }
        public void AssignStudents(int size)
        {

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
            
        }

    }
}
