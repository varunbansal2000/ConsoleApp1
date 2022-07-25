
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Entities;
using Application.DataAccess;
namespace Application.UI
{
    internal class Program
    {
        static IDataAccess<Department, int> dsDept = new DepartmentDataAccess();
        static IDataAccess<Employee, int> dsEmp= new EmployeeDataAccess();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Choose DB!!");
            Console.WriteLine("1.Department");
            Console.WriteLine("2.Employee");
            int c = Convert.ToInt32(Console.ReadLine());
            if(c == 1)
                deptA();
            else
                EmpA();

            // Since the Console App access IDataAccess classses
            // Methods from these classes throws exception so please catch them here

            Console.ReadLine();
        }
        static void EmpA()
        {
            int choice = 1;
            while (choice != 0)
            {

                Console.WriteLine("Employee DB");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Read All Records");
                Console.WriteLine("2. Read Record by Primary Key");
                Console.WriteLine("3. Create New Record");
                Console.WriteLine("4. Update Exisitng Record");
                Console.WriteLine("5. Delete Record");
                Console.WriteLine("Any other to terminate!");
                Console.Write("Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        var employees = dsEmp.Get();
                        PrintResults2(employees);
                        break;
                    case 2:
                        Console.Write("Enter primary key : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {


                            var emp = dsEmp.Get(id);
                            Console.WriteLine($"{emp.EmpNo}   {emp.EmpName} {emp.Salary} {emp.Designation} {emp.DeptNo}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Exception : " + ex.Message);
                        }
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 3:
                        try
                        {

                            var emplo = dsEmp.Get();
                            //PrintResults(Departments);
                            Console.WriteLine();
                            Console.WriteLine("Enter Employee Details like follows");
                            Console.WriteLine("EmpNo");
                            Employee employee= new Employee();
                            employee.EmpNo= Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("EmpName");
                            employee.EmpName= Console.ReadLine();
                            Console.WriteLine("Salary");
                            employee.Salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("DeptNo");
                            employee.DeptNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Designation");
                            employee.Designation = Console.ReadLine();
                            dsEmp.Craete(employee);
                            employees = dsEmp.Get();
                            PrintResults2(employees);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error Occurred {ex.Message}");
                        }
                        break;
                    case 4:
                        try
                        {

                            var emplo = dsEmp.Get();
                            //PrintResults(Departments);
                            Console.WriteLine();
                            Console.WriteLine("Enter Employee Details like follows");
                            Console.WriteLine("EmpNo");
                            Employee employee = new Employee();
                            employee.EmpNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("EmpName");
                            employee.EmpName = Console.ReadLine();
                            Console.WriteLine("Salary");
                            employee.Salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("DeptNo");
                            employee.DeptNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Designation");
                            employee.Designation = Console.ReadLine();
                            Console.Write("Enter id : ");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            dsEmp.Update(id2, employee);
                            employees = dsEmp.Get();
                            PrintResults2(employees);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error Occurred {ex.Message}");
                        }
                        break;
                    case 5:
                        Console.Write("Enter id : ");
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        dsEmp.Delete(id3);
                        break;
                    default:
                        choice = 0;
                        break;
                }

            }

        }
        static void deptA()
        {
            int choice = 1;
            while (choice != 0)
            {

                Console.WriteLine("Department DB");
                Console.WriteLine("Enter your Choice");
                Console.WriteLine("1. Read All Records");
                Console.WriteLine("2. Read Record by Primary Key");
                Console.WriteLine("3. Create New Record");
                Console.WriteLine("4. Update Exisitng Record");
                Console.WriteLine("5. Delete Record");
                Console.WriteLine("Any other to terminate!");
                Console.Write("Choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        var departmen = dsDept.Get();
                        PrintResults(departmen);
                        break;
                    case 2:
                        Console.Write("Enter primary key : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        var dept = dsDept.Get(id);
                        Console.WriteLine($"{dept.DeptNo}   {dept.DeptName} {dept.Location} {dept.Capacity}");
                        Console.WriteLine("-----------------------------------------");
                        break;
                    case 3:
                        try
                        {

                            var Departments = dsDept.Get();
                            //PrintResults(Departments);
                            Console.WriteLine();
                            Console.WriteLine("Enter Department Details like follows");
                            Console.WriteLine("DeptNo");
                            Department department = new Department();
                            department.DeptNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("DeptName");
                            department.DeptName = Console.ReadLine();
                            Console.WriteLine("Location");
                            department.Location = Console.ReadLine();
                            Console.WriteLine("Capacity");
                            department.Capacity = Convert.ToInt32(Console.ReadLine());
                            CreateDepartment(department);
                            Departments = dsDept.Get();
                            PrintResults(Departments);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error Occurred {ex.Message}");
                        }
                        break;
                    case 4:
                        try
                        {

                            var Departments = dsDept.Get();
                            //PrintResults(Departments);
                            Console.WriteLine();
                            Console.WriteLine("Enter Department Details like follows");
                            Console.WriteLine("DeptNo");
                            Department department = new Department();
                            department.DeptNo = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("DeptName");
                            department.DeptName = Console.ReadLine();
                            Console.WriteLine("Location");
                            department.Location = Console.ReadLine();
                            Console.WriteLine("Capacity");
                            department.Capacity = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter id : ");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            dsDept.Update(id2, department);
                            Departments = dsDept.Get();
                            PrintResults(Departments);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error Occurred {ex.Message}");
                        }
                        break;
                    case 5:
                        Console.Write("Enter id : ");
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        dsDept.Delete(id3);
                        break;
                    default:
                        choice = 0;
                        break;
                }

            }
        }

        static void PrintResults(IEnumerable<Department> depts)
        {
            Console.WriteLine("DeptNo   DeptName    Location    Capacity");
            foreach (var dept in depts)
            {
                Console.WriteLine($"{dept.DeptNo}   {dept.DeptName}      {dept.Location}             {dept.Capacity}");
            }
            Console.WriteLine("-----------------------------------------");
        }

        static void PrintResults2(IEnumerable<Employee> emps)
        {
            Console.WriteLine("EmpNo empName    Salary     Designation     DeptNo");
            foreach (var dept in emps)
            {
                Console.WriteLine($"{dept.EmpNo}      {dept.EmpName}       {dept.Salary}             {dept.Designation}       {dept.DeptNo}");
            }
            Console.WriteLine("-----------------------------------------");
        }
        static void CreateDepartment(Department department)
        {
            dsDept.Craete(department);
        }
    }
}