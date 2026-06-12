using System;

namespace DrivingCoursesClasses.Classes
{
    public struct FullName
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }

        public FullName(string name, string surname, string fathername)
        {
            Name = name;
            Surname = surname;
            FatherName = fathername;
        }
    }
}