using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentMid
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cse = new Department("CSE");

            Course oop2 = new Course("OOP2", "3012");
            Course oop1= new Course("JAVA", "3011");
            cse.AddCourse(oop2);
            cse.AddCourse(oop1);
            Section A = new Section("A");
            Section B = new Section("B");
            oop2.AddSection(A);
            oop1.AddSection(B);
            Faculty F = new Faculty("Irina", "19392971",15f);
            F.AddSection(A);
            F.AddSection(B);
            A.AddTeacher(F);
            B.AddTeacher(F);
            Console.WriteLine("\n***************info from Course object***************");
            oop1.ShowSectionFaculty();
            Console.WriteLine("\n***************Section info from Faculty object***************");
            F.ShowSectionDetails();
            Console.ReadLine();
        }
   
    }
}
