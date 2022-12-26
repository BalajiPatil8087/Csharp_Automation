using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    public class Employee
    {
        public int empID;
        public string Empname;
        private  double _empSalary;
        public static string companyName;
        public static string companyLocation;
        public char empPerformanceType;


        public double EmpSalary
        {
            get { 
                //read
                return _empSalary; }
            set 
            {
                //write
                 if(value>3000)
                {
                    _empSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid salary .so default value remain ");
                }
            }
        }

       public void PrintEmployeeDetail()
        {
            Console.WriteLine("Employee ID: " + empID);
            Console.WriteLine("Employee Name: " + Empname);
            Console.WriteLine("Employee Salary: " + _empSalary);
            Console.WriteLine("PerformanceType" + empPerformanceType);
            Console.WriteLine("Company Name " + Employee.companyName);
            Console.WriteLine("Company Location " + Employee.companyLocation);


        }
         public void GetGrossSalaryWithBonus()
          {
            Console.WriteLine("Employee ID: " + empID);
            if (empPerformanceType == 'A')
            {
                Console.WriteLine("25 %");
                Console.WriteLine(_empSalary + (_empSalary * 25 / 100));

            }
            else if (empPerformanceType == 'B')
            {
                Console.WriteLine("15 %");
                Console.WriteLine(_empSalary + (_empSalary * 15 / 100));
            }
            else if (empPerformanceType == 'C')
            {
                Console.WriteLine("15 %");
                Console.WriteLine(_empSalary + (_empSalary * 10 / 100));
            }
            else
            {
                Console.WriteLine("Not eligible for bonus");

            }
        }
    }
}

    
    

