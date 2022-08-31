using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadassaGoodman.Q2
{
    public class StudentCourse
    {
        public StudentCourse(int studentId, int courseID)
        {
            StudentId = studentId;
            Courses = new List<int>();
            AddCourseId(courseID);
        }

        public void AddCourseId(int coureId)
        {
            Courses.Add(coureId);
        }

        public int StudentId;
        public List<int> Courses;

    }
}
