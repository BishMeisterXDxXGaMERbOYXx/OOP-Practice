using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Practice
{
    class Student
    {
        private string forename;
        private string surname;
        private string predGrade;
        private string grade;

        public Student(string f, string s, string pg, string g)
        {
            forename = f;
            surname = s;
            predGrade = pg;
            grade = g;
        }

        public static Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            {"A*", 140},
            {"A", 120},
            {"B", 100},
            {"C", 80},
            {"D", 60},
            {"E", 40},
            {"U", 0}
        };

        public int CalculateVA()
        {
            int valueAdded;
            valueAdded = grades[grade] - grades[predGrade];

            return valueAdded;
        }

    }
}
