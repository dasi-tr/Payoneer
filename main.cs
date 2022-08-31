using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using HadassaGoodman.Q2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HadassaGoodman
{
    [TestClass]
    public class main
    {
        [TestMethod]
        public void Q1_GetMaxRevenue()
        {
            int[] prices = new[] { 5, 4, 9, 2, 8, 7, 7, 9, 6, 8, };

            Q1.Q1 q1 = new Q1.Q1();
            var index = q1.GetMaxRevenue(prices);
        }

        [TestMethod]
        public void Q2_ex1()
        {
            var studentCourseGrade = new List<StudentCourseGrade>()
            {
                new StudentCourseGrade(){StudentId = 1,CourseId=1123,Grade = 34},
                new StudentCourseGrade(){StudentId = 1,CourseId=1124,Grade = 88},
                new StudentCourseGrade(){StudentId = 2,CourseId=1123,Grade = 65},
            };

            //ex1
            List<StudentCourse> studentCourse = new List<StudentCourse>();
            foreach (var student in studentCourseGrade)
            {
                StudentCourse studenDefault = studentCourse.Where(o => o.StudentId == student.StudentId).FirstOrDefault();
                if (studenDefault!=null)
                {
                    studenDefault.AddCourseId(student.CourseId);
                }
                else
                {
                    studentCourse.Add(new StudentCourse(student.StudentId,student.CourseId));
                }
            }
        }

        [TestMethod]
        public void Q2_ex2()
        {
            var studentCourseGrade = new List<StudentCourseGrade>()
            {
                new StudentCourseGrade(){StudentId = 1,CourseId=1123,Grade = 34},
                new StudentCourseGrade(){StudentId = 1,CourseId=1124,Grade = 88},
                new StudentCourseGrade(){StudentId = 2,CourseId=1123,Grade = 65},
            };

            //ex2

            List<CourseGrades> courseGrades = new List<CourseGrades>();
            foreach (var student in studentCourseGrade)
            {
                CourseGrades grades = courseGrades.Where(o => o.CourseID == student.CourseId).FirstOrDefault();
                if (grades != null)
                {
                    grades.AddGrade(student.Grade);
                }
                else
                {
                    courseGrades.Add(new CourseGrades(student.CourseId, student.Grade));
                }
            }

        }

    }
}
