using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_12July_.Logic;
using Employee_12July_.Models;
namespace Employee_12July_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Manager e1= new Manager(20000,80000,1,"John","Pro Manager",1000000);

            SalesManager e2 = new SalesManager(5000,10000,20000,30000,80000,2,"Kiara","Dimen Sales Manager",1200000);

            Engineer e3 = new Engineer(2000, 10, 3, "Jenny", 800000, "ProDimen Engineer");
            Engineer e4 = new Engineer(2000, 10, 4, "Tom", 800000, "ProDimen Engineer");
            EmployeeLogic employeeLogic = new EmployeeLogic();
            employeeLogic.AddEmployee(e1);
            employeeLogic.AddEmployee(e2);
            employeeLogic.AddEmployee(e3);
            employeeLogic.AddEmployee(e4);

            List<Employee> employees = employeeLogic.GetEmployees();
            Console.WriteLine("Original List");
            employeeLogic.showEmployees(employees);
            
            employeeLogic.SearchEmployee("John");
            
            employeeLogic.SearchEmployee("Varun");

            Engineer e5 = new Engineer(2000, 10, 3, "New Jenny", 800000, "ProDimen Enginner");
            employees = employeeLogic.UpdateEmployee(3, e5);
            Console.WriteLine();
            Console.WriteLine("After updation");
            
            employeeLogic.showEmployees(employees);
            employees = employeeLogic.DeleteEmployee(4);
            Console.WriteLine();
            Console.WriteLine("After deletion");
           
            employeeLogic.showEmployees(employees);

            Account account = new Account();
            account.showSalary(employees);

            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine($"Name - {e.EmpName}");
            //    Console.WriteLine($"ID - {e.EmpNo}");
            //    Console.WriteLine($"Dept Name - {e.DeptName}");
            //    Console.WriteLine($"Gross Salary - {e.grossSalary()}");
            //    Console.WriteLine($"Tax Paid - {e.tax()}");
            //    Console.WriteLine($"Net Salary - {e.netSalary()}");
            //    Console.WriteLine();
            //}
            Console.ReadLine();


        }

        //public string inWords(int )
    }
}
