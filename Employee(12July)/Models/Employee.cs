using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_12July_.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }
        public decimal BasicSalary { get; set; }

        

        public Employee(int empNo, string empName, string deptName, decimal basicSalary)
        {
            EmpNo = empNo;
            EmpName = empName;
            DeptName = deptName;
            BasicSalary = basicSalary;
        }
        public virtual int grossSalary()
        {
            Console.WriteLine("Base Class)");
            return 0;
        }

        public virtual double tax()
        {
            Console.WriteLine("Base Class)");
            return 0;
        }

        public virtual double netSalary()
        {
            Console.WriteLine("Base Class)");
            return 0;
        }
    }
}
