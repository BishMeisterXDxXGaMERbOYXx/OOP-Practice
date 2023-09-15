using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class ComputingDepartment
    {

        private ComputingClass[] classes;
        public ComputingDepartment()
        {
            public ComputingDepartment(){}

            public void CreateClasses(int number)
            {
                classes = new ComputingClass[number];
                string className;
                string teacherName;

                for(int i = 0; i < classes.Length; i++)
                {
                    Console.Write("Class name: ");
                    className = Console.ReadLine();
                    Console.Write("Teacher's name: ");
                    teacherName = Console.ReadLine();
                    classes[i] = new ComputingClass(className, teacherName);
                }
            }

            
        }

    }
}
