using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public delegate void CheckChange(int oldNumber, int newNumber);
    class Course
    {
        private int courseID;
        private string courseTitle;
        private Dictionary<Student, double> list = new Dictionary<Student, double>();
        public int CourseID { get => courseID; set => courseID = value; }
        public string CourseTitle { get => courseTitle; set => courseTitle = value; }

        public event CheckChange OnNumberOfStudentChange;
        public Course(int courseID, string courseTitle)
        {
            CourseID = courseID;
            CourseTitle = courseTitle;
        }
        public void AddStudent(Student p, double g)
        {
            list.Add(p, g);
            if (OnNumberOfStudentChange != null)
            {
                OnNumberOfStudentChange(list.Count - 1, list.Count);
            }
        }

        public void RemoveStudent(int StudentID)
        {
            foreach (var i in list)
            {
                if (i.Key.StudentID == StudentID)
                {
                    list.Remove(i.Key);

                    if (OnNumberOfStudentChange != null)
                    {
                        OnNumberOfStudentChange(list.Count + 1, list.Count);
                    }
                    break;
                }
            }
        }

        public override string ToString()
        {
            string kq = $"Course : {CourseID} - {CourseTitle}\n";
            foreach (var i in list)
            {
                kq += $"Student: {i.Key.StudentID} - {i.Key.StudentName} - Mark: {i.Value} \n";
            }
            return kq;
        }
    }
}
