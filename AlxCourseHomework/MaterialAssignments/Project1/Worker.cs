using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public abstract class Worker 
    {
        public string Name;
        public EnumContractTypes? Contract;
        public double Salary;
        public double MonthlyRate;
        public double Overtime;

        public Worker()
        {
            Contract = EnumContractTypes.TRAINEE;
        }

        public void ChangeContract(Worker worker)
        {
            if (worker.Contract == EnumContractTypes.TRAINEE)
            {
                worker.Contract = EnumContractTypes.FULLTIME;
                worker.MonthlyRate = 5000;
            }
            else
            {
                worker.Contract = EnumContractTypes.TRAINEE;
                worker.MonthlyRate = 1000;
                worker.Overtime = 0;
            }
        } 
        public double ShowSalary()
        {
            Console.WriteLine(Math.Round(Salary,2).ToString());
            return Salary;
        }

        public void Present()
        {
            Console.WriteLine($"{Name.ToLower().Replace(" ","")}{Math.Round(Salary,2)}");
        }
    }
}
