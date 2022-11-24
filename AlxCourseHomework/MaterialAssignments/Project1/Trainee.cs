using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class Trainee : Worker 
    {

        public Trainee(string name):base()
        {
            MonthlyRate = 1000;
            Name = name;
        }
        public double CalculateSalary()
        {
            return Salary = (MonthlyRate + (Overtime * (MonthlyRate / 60)));
        }
        public void ShowWorker()
        {
            Console.WriteLine($"Worker name: {Name}");
            Console.WriteLine($"Worek contract: {Contract}");
            Console.WriteLine($"Overtime: {Overtime}");
            Console.WriteLine($"Salary: {Math.Round(Salary,2)}");
        }
    }
}
