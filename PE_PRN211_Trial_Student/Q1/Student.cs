using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Student
    {
        private int studentID;
        private string studentName;

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }

        public Student(int studentID, string studentName)
        {
            StudentID = studentID;
            StudentName = studentName;
        }
    }
}
