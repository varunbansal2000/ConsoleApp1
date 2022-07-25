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
            
            int choice = 1;
            while(choice != 0)
            {
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Read All Records");
                Console.WriteLine("2. Search by name");
                Console.WriteLine("3. Create New Record");
                Console.WriteLine("4. Update Exisitng Record");
                Console.WriteLine("5. Delete Record");
                Console.WriteLine("6. Show Salary details!");
                Console.WriteLine("Any other to terminate!");
                Console.Write("Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice) {
                    case 1:
                        List<Employee> employees = employeeLogic.GetEmployees();
                        Console.WriteLine("Original List");
                        employeeLogic.showEmployees(employees);
                        break;
                    case 2:
                        Console.Write("Enter name : ");
                        string name = Console.ReadLine();
                        employeeLogic.SearchEmployee(name);
                        break;
                    case 3:
                        Console.Write("Enter EmpNo : ");
                        int empNo = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Name : ");
                        string n = Console.ReadLine();
                        Console.Write("Enter dept Name : ");
                        string deptName = Console.ReadLine();
                        Console.Write("Enter Basic Salary : ");
                        int bs = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Designation choice!");
                        Console.WriteLine("1: Engineer");
                        Console.WriteLine("2. Manager");
                        Console.WriteLine("3. Sales Manager");
                        int c = Convert.ToInt32(Console.ReadLine());
                        if(c == 1)
                        {
                            Console.Write("Enter OverTime : ");
                            int overTime = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter overTime per Hour : ");
                            int overTimePerHour = Convert.ToInt32(Console.ReadLine());
                            Engineer e = new Engineer(overTime, overTimePerHour, empNo, n, bs, deptName);
                            employeeLogic.AddEmployee(e);

                        } else if(c == 2)
                        {
                            Console.Write("Enter ProjectAllowance : ");
                            int pa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter TravelAllowance : ");
                            int ta= Convert.ToInt32(Console.ReadLine());
                            Manager m = new Manager(pa, ta, empNo, n, deptName, bs);
                            employeeLogic.AddEmployee(m);
                        } else
                        {
                            Console.Write("Enter ProjectAllowance : ");
                            int pa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter TravelAllowance : ");
                            int ta = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter hotelAllowance : ");
                            int ha = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter petrolAllowance : ");
                            int pa2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter CustomAllowance : ");
                            int ca = Convert.ToInt32(Console.ReadLine());
                            SalesManager sm = new SalesManager(pa2, ha, ca, pa, ta, empNo, n, deptName, bs);
                            employeeLogic.AddEmployee(sm);
                        }
                        break;
                    case 4:
                        Console.Write("Enter EmpNo for updation : ");
                        int empN = Convert.ToInt32(Console.ReadLine());
                        List<Employee> employees4 = employeeLogic.GetEmployees();
                        Employee em = employees4[empN];
                        Console.Write("Enter Name : ");
                        string n2 = Console.ReadLine();
                        Console.Write("Enter dept Name : ");
                        string deptName2 = Console.ReadLine();
                        Console.Write("Enter Basic Salary : ");
                        int bs2 = Convert.ToInt32(Console.ReadLine());
                        if(em is Engineer)
                        {
                            Console.Write("Enter OverTime : ");
                            int overTime2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter overTime per Hour : ");
                            int overTimePerHour2 = Convert.ToInt32(Console.ReadLine());
                            Engineer e = new Engineer(overTime2, overTimePerHour2, empN, n2, bs2, deptName2);
                            employeeLogic.UpdateEmployee(empN, e);
                        } else if(em is Manager)
                        {
                            Console.Write("Enter ProjectAllowance : ");
                            int pa2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter TravelAllowance : ");
                            int ta2 = Convert.ToInt32(Console.ReadLine());
                            Manager m = new Manager(pa2, ta2, empN, n2, deptName2, bs2);
                            employeeLogic.UpdateEmployee(empN,m);
                        } else
                        {
                            Console.Write("Enter ProjectAllowance : ");
                            int pa = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter TravelAllowance : ");
                            int ta = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter hotelAllowance : ");
                            int ha = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter petrolAllowance : ");
                            int pa2 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter CustomAllowance : ");
                            int ca = Convert.ToInt32(Console.ReadLine());
                            SalesManager sm = new SalesManager(pa2, ha, ca, pa, ta, empN, n2, deptName2, bs2);
                            employeeLogic.UpdateEmployee(empN,sm);
                        }
                     
                        break;
                    case 5:
                        Console.Write("Id for deletion: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        employeeLogic.DeleteEmployee(id);
                        List<Employee> employees2 = employeeLogic.GetEmployees();
                        Console.WriteLine(" List after deletion");
                        employeeLogic.showEmployees(employees2);
                        break;
                    case 6:
                        List<Employee> employees3 = employeeLogic.GetEmployees();
                        Account account = new Account();
                        account.showSalary(employees3);
                        break;
                    default:
                        choice = 0;
                        break;

                }
                
            }
            //List<Employee> employees = employeeLogic.GetEmployees();
            //Console.WriteLine("Original List");
            //employeeLogic.showEmployees(employees);
            
            //employeeLogic.SearchEmployee("John");
            
            //employeeLogic.SearchEmployee("Varun");

            //Engineer e5 = new Engineer(2000, 10, 3, "New Jenny", 800000, "ProDimen Enginner");
            //employees = employeeLogic.UpdateEmployee(3, e5);
            //Console.WriteLine();
            //Console.WriteLine("After updation");
            
            //employeeLogic.showEmployees(employees);
            //employees = employeeLogic.DeleteEmployee(4);
            //Console.WriteLine();
            //Console.WriteLine("After deletion");
           
            //employeeLogic.showEmployees(employees);

            //Account account = new Account();
            //account.showSalary(employees);

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
