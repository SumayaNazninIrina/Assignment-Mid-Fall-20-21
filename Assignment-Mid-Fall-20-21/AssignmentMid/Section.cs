using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Section
    {
        private String name;
        Faculty FacultyName;

        public string SectionName
        {
            get { return name; }
            set { name = value; }
        }
        public Section(string sectionName)
        {
            this.name = sectionName;
        }

        public void AddTeacher(Faculty teacherName)
        {
            if (teacherName.Counttime < 21)
            {
                this.FacultyName = teacherName;
            }
            else
            {
                Console.WriteLine("course can't add");
            }

        }

        public void ShowDetails()
        {
            Console.WriteLine("Section:" + name);
            FacultyName.ShowFInfo();
        }
    }
}
