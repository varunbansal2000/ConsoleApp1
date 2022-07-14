using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_12July_.Logic;
using Employee_12July_.Models;


namespace Employee_12July_.Logic
{
    public class Account
    {
        public void showSalary(List<Employee> l)
        {
            foreach (Employee emp in l)
            {
                Console.WriteLine("Salary Details of " + emp.EmpName);
                Console.WriteLine($"Gross Salary - {emp.grossSalary()}");
                Console.WriteLine($"Tax Paid - {emp.tax()}");
                Console.WriteLine($"Net Salary - {emp.netSalary()}");
                toWords(emp.netSalary());
                Console.WriteLine();
            }
        }

        public void toWords(double d)
        {
            int n = (int)d;
            string[] arr = { "zero","one","two","three","four","five","six","seven","eight","nine" };
            string ans = string.Empty;

            while(n>0)
            {
                int ld = n % 10;
                n = n / 10;
                ans = arr[ld] + " "+ ans;
            }

            Console.WriteLine("salary in words : "+ ans);
        }

    }
}
