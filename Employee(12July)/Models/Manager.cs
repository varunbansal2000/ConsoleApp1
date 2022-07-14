using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_12July_.Models
{
    public class Manager: Employee
    {
       

        public int ProjectAlowances { get; set; }
        public int TravelAlowances { get; set; }

        public Manager(int projectAllowances, int TravelAllowances,int empNo, string empName, string deptName, decimal basicSalary) : base(empNo, empName, deptName, basicSalary)
        {
            ProjectAlowances = projectAllowances;
            TravelAlowances = TravelAllowances; 
        }

        public override int grossSalary()
        {
            return (int)(BasicSalary + ProjectAlowances + TravelAlowances);
        }

        public override double tax()
        {
            double taxAmount = 0;
            int gs = grossSalary();
            if (gs > 10000000)
            {
                taxAmount = ((gs - 1000000) * 0.4) + 250000;
            }
            else if (gs > 500000)
            {
                taxAmount = (gs - 500000) * 0.3 + 100000;
            }
            else
                taxAmount = gs * 0.2;
            return taxAmount;

        }

        public override double netSalary()
        {
            return grossSalary() - tax();
        }
    }
}
