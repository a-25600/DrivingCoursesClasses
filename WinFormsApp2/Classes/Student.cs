using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;

namespace DrivingCoursesClasses.Classes
{
    public class Student
    {
        public int Id { get; set; }

        private FullName _currName;

        public List<CourseInfo> Courses { get; set; }

        [DisplayName("Прізвище")]
        public string Surname => _currName.Surname;

        [DisplayName("Ім'я")]
        public string Name => _currName.Name;

        [DisplayName("По батькові")]
        public string FatherName => _currName.FatherName;

        public Student()
        {
            Courses = new List<CourseInfo>();
        }

        public void SetFullName(string name, string surname, string fathername)
        {
            _currName = new FullName(name, surname, fathername);
        }

        public void AddCourse(string category)
        {
            var newCourse = new CourseInfo { Category = category };
            Courses.Add(newCourse);
        }
    }
}