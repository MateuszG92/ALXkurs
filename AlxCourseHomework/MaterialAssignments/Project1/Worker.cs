using AlxCourseHomework.MaterialAssignments.Project1.Interfaces;
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
        public string FirstName;
        public string LastName;
        public EnumContractTypes? Contract;
        public double Salary;
        public double MonthlyRate;
        public int Overtime;

        public Worker(string firstName, string lastName)
        {
            Contract = EnumContractTypes.TRAINEE;
            Overtime = 0;
        }

        public void ChangeContract()
        {
            if (Contract == EnumContractTypes.TRAINEE)
            {
                Contract = EnumContractTypes.FULLTIME;
            }
            else
            {
                Contract = EnumContractTypes.TRAINEE;
            }
        } 
        public void ShowSalary()
        {
            Console.WriteLine(Salary.ToString());
        }

        public void Present()
        {
            Console.WriteLine($"{FirstName}{LastName}{Salary.ToString()}");
        }
    }
}
