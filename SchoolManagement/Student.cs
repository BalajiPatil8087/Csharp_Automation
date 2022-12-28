using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        public int StudentId;
        public string StudentName;
        public string StudentMailID;
        public double Percentage;
        public static string SchoolName;
        public static string SchoolAddress;

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student ID:" + StudentId);
            Console.WriteLine("Student Name:" + StudentName);
            Console.WriteLine("Student MailID:" + StudentMailID);
            Console.WriteLine("Percentage:" + Percentage);
            Console.WriteLine("SchoolName:" + Student.SchoolName);
            Console.WriteLine("SchoolAddress:" + Student.SchoolAddress);
        }
        public void DisplayCertification()
        {
            if (Percentage >= 90 && Percentage <= 100)
            {
                Console.WriteLine("Hi " + StudentName + "You have successfully passed with grade A ");
            }
            else if (Percentage >= 80 && Percentage <= 89)
            {
                Console.WriteLine("Hi " + StudentName + "You have successfully passed with grade B ");
            }
            else if (Percentage >= 60 && Percentage <= 79)
            {
                Console.WriteLine("Hi " + StudentName + "You have successfully passed with grade c ");

            }
            else
            {
                Console.WriteLine("Hi " + StudentName + "You have Fail this Exam ");
            }

        }
    }
}

