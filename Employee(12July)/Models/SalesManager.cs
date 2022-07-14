using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_12July_.Models
{
    public class SalesManager : Manager
    {
        

        public int petrolAllowance { get; set; }
        public int hotelAllowance { get; set; }
        public int customAllowance { get; set; }

        public SalesManager(int petrolAllowances,int hotelAllowances, int customAllowances, int projectAllowances, int TravelAllowances, int empNo, string empName, string deptName, decimal basicSalary) : base(projectAllowances, TravelAllowances, empNo, empName, deptName, basicSalary)
        {
            petrolAllowance = petrolAllowances;
            hotelAllowance = hotelAllowances;
            customAllowance = customAllowances;
        }

        public override int grossSalary()
        {
            return (int)(petrolAllowance +hotelAllowance+customAllowance+ProjectAlowances+TravelAlowances+BasicSalary);
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
