using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Student stud1 = new Student();
            Student stud2 = new Student();
            Student stud3 = new Student();

            stud1.StudentId = 1001;
            stud1.StudentName = "jack";
            stud1.StudentMailID = "jack@gmail.com";
            stud1.Percentage = 45.2;
            Student.SchoolName = "Global school";
            Student.SchoolAddress = "chennai";

            

            stud2.StudentId = 1002;
            stud2.StudentName = "peter";
            stud2.StudentMailID = "peter@gmail.com";
            stud2.Percentage = 85.2;
            Student.SchoolName = "Global school";
            Student.SchoolAddress = "chennai";

            

            stud3.StudentId = 1003;
            stud3.StudentName = "mark";
            stud3.StudentMailID = "mark@gmail.com";
            stud3.Percentage = 56.5;
            Student.SchoolName = "Global school";
            Student.SchoolAddress = "chennai";

           

            stud1.PrintStudentDetails();
            stud1.DisplayCertification();

            stud2.PrintStudentDetails();
            stud2.DisplayCertification();

            stud3.PrintStudentDetails();
            stud3.DisplayCertification();



        }
    }
}
