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
        public string Name { get; set; }
        public EnumContractTypes? Contract { get; set; }
        public double Salary { get; set; }
        public double MonthlyRate { get; set; }
        public double Overtime { get; set; }

        public Worker()
        {

        }

        public static Worker ChangeContract(Worker worker)
        {
            if (worker.Contract == EnumContractTypes.TRAINEE)
            {
                return new FullTime(worker.Name);
            }
            else
            {
                return new Trainee(worker.Name);
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
        public virtual void ShowWorker()
        {
            Console.WriteLine($"Worker name: {Name}");
            Console.WriteLine($"Worek contract: {Contract}"); ;
            Console.WriteLine($"Salary: {Math.Round(Salary, 2)}");
        }
        public virtual double CalculateSalary()
        {
            return Salary = MonthlyRate;
        }
    }
}
