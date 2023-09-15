using System;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            ComputingClass tjc = new ComputingClass("tjc");

            tjc.AssignStudents(2);
            Console.WriteLine(tjc.AverageValueAdded());

        }
    }
}
