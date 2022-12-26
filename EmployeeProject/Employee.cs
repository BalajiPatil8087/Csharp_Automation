using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empID;
        public string Empname;
        public double empSalary;
        public static string companyName;
        public static string companyLocation;

        public void PrintEmployeeDetail()
        {
            Console.WriteLine("Employee ID: "+empID);
            Console.WriteLine("Employee Name: " +Empname);
            Console.WriteLine("Employee Salary: " +empSalary);
            Console.WriteLine("Company Name "+Employee.companyName);
            Console.WriteLine("Company Location " + Employee.companyLocation);

        }


    }
}
