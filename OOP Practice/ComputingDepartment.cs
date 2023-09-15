using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP_Practice
{
    class ComputingDepartment
    {

        private ComputingClass[] classes;
        public ComputingDepartment()
        {}

        public void CreateClasses(int number)
        {

            int[] numberOfStudents;

            if (number > 5)
            {
                Console.WriteLine("There are too many classes!");
            }
            else
            {

                classes = new ComputingClass[number];
                numberOfStudents = new int[number];
                string className;
                string teacherName;

                for (int i = 0; i < classes.Length; i++)
                {
                    Console.Write("Class name: ");
                    className = Console.ReadLine();
                    Console.Write("Teacher's name: ");
                    teacherName = Console.ReadLine();
                    Console.Write("Number of students in Class: ");
                    numberOfStudents[i] = Convert.ToInt32(Console.ReadLine());
                    classes[i] = new ComputingClass(className, teacherName);
                }
            }

            for (int i = 0; i < classes.Length; i++)
            {
                string className = classes[i].GetClassName();
                Console.WriteLine(String.Format("Students for class {0}: ", className));

                classes[i].AssignStudents(numberOfStudents[i]);
            }

        }



    }
}
