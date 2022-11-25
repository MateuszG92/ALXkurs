using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class Service
    {
        public static void Run()
        {
            Worker trainee1 = new Trainee("Mateusz Gumkowski");
            trainee1.CalculateSalary();
            trainee1.Present();
            trainee1.ShowSalary();
            trainee1.ShowWorker();
            trainee1= Worker.ChangeContract(trainee1);
            trainee1.Overtime = 50;
            Console.WriteLine(trainee1.Overtime);
            trainee1.CalculateSalary();
            trainee1.ShowWorker();
            trainee1.ShowSalary();
            trainee1.Present();
            Worker fulltime1 = new FullTime("Someone Something");
            fulltime1.CalculateSalary();
            fulltime1.Present();
            fulltime1.ShowSalary();
            fulltime1.ShowWorker();
            fulltime1 = Worker.ChangeContract(fulltime1);
            fulltime1.CalculateSalary();
            fulltime1.ShowWorker();
            fulltime1.ShowSalary();
            fulltime1.Present();
        }
    }
}
