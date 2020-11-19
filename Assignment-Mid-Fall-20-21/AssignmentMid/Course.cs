using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Course
    {
        private string courseName;
        private string courseId;
        Section[] sectionName = new Section[5];
        private int countSection = 0;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public string CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        public Course(string cn, string cid)
        {
            this.courseName = cn;
            this.courseId = cid;
        }

        public void AddSection(Section sn)

        {

            this.sectionName[countSection++] = sn;
        }
        public void ShowSectionFaculty()
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
