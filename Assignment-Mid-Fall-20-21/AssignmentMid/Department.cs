using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Department
    {
        private string departmentName;
        Course[] courseName = new Course[50];
        private int countCourse = 0;

        public string DepartmentName
        {
            get { return departmentName; }
            set { departmentName = value; }
        }
        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public void ShowDInfo()
        {
            Console.WriteLine(departmentName);
        }
        public void AddCourse(Course courseName)
        {
            this.courseName[countCourse++] = courseName;
        }
    }
}
