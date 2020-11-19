using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Faculty
    {
        private string FacultyName;
        private string FacultyId;
        public float Counttime;
        Section[] sectionName = new Section[5];
        private int countSection = 0;

        public string TeacherName
        {
            get { return FacultyName; }
            set { FacultyName = value; }
        }

        public string TeacherId
        {
            get { return FacultyId; }
            set { FacultyId = value; }
        }
        
        public float TotalHourOfClass
        {
            get { return Counttime; }
            set { Counttime = value; }
        }
        public Faculty(string teacherName, string teacherId, float totalHourOfClass)
        {
            this.FacultyName = teacherName;
            this.FacultyId = teacherId;
            this.Counttime = totalHourOfClass;
        }

        public void AddSection(Section sectionName)
        {
            this.sectionName[countSection] = sectionName;
            countSection++;
            Counttime += 2.0f;
        }

        public void ShowFInfo()
        {
            Console.WriteLine("Teacher's Name: " + FacultyName);
            Console.WriteLine("Teacher's Id: " + FacultyId);
        }

        public void ShowSectionDetails()
        {
            for(int i=0;i<10;i++)
            {
                if (sectionName[i] != null)
                {
                    sectionName[i].ShowDetails();
                }
                else { break; }
            }
        }
    }
}
