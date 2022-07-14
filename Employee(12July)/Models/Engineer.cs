using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_12July_.Models
{
    public class Engineer : Employee
    {
        public int overTime { get; set; }
        public int overTimeHours { get; set; }

        public Engineer(int overTime, int overTimeHours,int EmpNo,string empName, int basicSalary, string deptName): base(EmpNo,empName,deptName,basicSalary)
        {
            this.overTime = overTime;
            this.overTimeHours = overTimeHours;
        }

        public override int grossSalary()
        {
            return (int)(BasicSalary + (overTime * overTimeHours));
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
            return grossSalary()-tax();
        }
    }
}
