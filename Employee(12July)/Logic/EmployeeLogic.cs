using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_12July_.Models;

namespace Employee_12July_.Logic
{
    public class EmployeeLogic
    {
        List<Employee> employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            return employees;
        }

        public List<Employee> AddEmployee(Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        public List<Employee> UpdateEmployee(int empno, Employee employee)
        {
            // Logic for Update
            int index = -1;
            foreach(Employee emp in employees)
            {
                if(emp.EmpNo == empno)
                {
                    index = employees.IndexOf(emp);
                }
            }
            if(index != -1)
                employees[index] = employee;
            return employees;
        }

        public List<Employee> DeleteEmployee(int empno)
        {
            // Logic for Delete
            int index = -1;
            foreach (Employee emp in employees)
            {
                if (emp.EmpNo == empno)
                {
                    index = employees.IndexOf(emp);
                }
            }
            if(index!= -1)
                employees.RemoveAt(index);
            return employees;
        }

        public List<Employee> SearchEmployee(string dname)
        {
            // Logic for s3earch by danme
            int index = -1;
            foreach (Employee emp in employees)
            {
                if (emp.EmpName == dname)
                {
                    index = employees.IndexOf(emp);
                }
            }
            if (index != -1)
                Console.WriteLine(dname + " Found !!");
            else
                Console.WriteLine(dname + " Not Found!");
            return employees;
        }

        public void showEmployees(List<Employee> l)
        {
            Console.WriteLine(".........................");
            foreach (Employee e in l)
            {


                Console.WriteLine($"Name - {e.EmpName}");
                Console.WriteLine($"ID - {e.EmpNo}");

                Console.WriteLine($"Dept Name - {e.DeptName}");
            }
            Console.WriteLine(".........................");
        }
    
    }
}
