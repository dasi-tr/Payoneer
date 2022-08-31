using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HadassaGoodman.Q2
{
    public class CourseGrades
    {
        public int CourseID { get; set; }
        private List<int> Grades { get; set; }
        public  double Avg { get; set; }

        public CourseGrades(int courseID, int grade)
        {
            CourseID = courseID;
            Grades = new List<int>();
            AddGrade(grade);
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            AvgGradeCalculate();
        }

        private void AvgGradeCalculate()
        {
            if (Grades != null)
                Avg = Grades.Average();
        }
    }
}
