using EmployeeProject;

namespace  Maveric.Runner;
    public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*****Employee DashBorad*****");
        Employee.companyName = "Maveric";
        Employee.companyLocation = "Chennai";



        Employee emp1 = new Employee();
        Employee emp2 = new Employee();
        Employee emp3 = new Employee();

        emp1.empID = 101;
        emp1.Empname = "saul";
        emp1.empSalary = 9000;

        emp2.empID = 102;
        emp2.Empname = "kim";
        emp2.empSalary = 12000.2;

        emp3.empID = 103;
        emp3.Empname = "jack";
        emp3.empSalary = 6000;

        Employee.companyName = "Maveric compnay";

        Console.WriteLine(emp1.empID);
        Console.WriteLine(emp1.Empname);
        Console.WriteLine(emp1.empSalary);

        Console.WriteLine("******************");

        Console.WriteLine(emp2.empID);
        Console.WriteLine(emp2.Empname);
        Console.WriteLine(emp2.empSalary);

        Console.WriteLine("******************");
        
        Console.WriteLine(emp3.empID);
        Console.WriteLine(emp3.Empname);
        Console.WriteLine(emp3.empSalary);

        Console.WriteLine(Employee.companyName);
        Console.WriteLine(Employee.companyLocation);
    }
}

