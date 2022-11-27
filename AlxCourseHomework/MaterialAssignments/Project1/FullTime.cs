using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class FullTime : Worker, IWorker
    {
        public FullTime(string name) : base()
        {
            MonthlyRate = 5000;
            Overtime = 0;
            Name = name;
            Contract = EnumContractTypes.FULLTIME;
        }
        public override double CalculateSalary()
        {
            return Salary=(MonthlyRate + (Overtime * (MonthlyRate / 60)));
        }
        public override void ShowWorker()
        {
            Console.WriteLine($"Worker name: {Name}");
            Console.WriteLine($"Worek contract: {Contract}");
            Console.WriteLine($"Overtime: {Overtime}");
            Console.WriteLine($"Salary: {Math.Round(Salary, 2)}");
        }
    }
}
