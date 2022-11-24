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
            var trainee1 = new Trainee("Mateusz Gumkowski");
            trainee1.CalculateSalary();
            trainee1.Present();
            trainee1.ShowSalary();
            trainee1.ShowWorker();
            trainee1.ChangeContract(trainee1);
            trainee1.Overtime = 50;
            trainee1.CalculateSalary();
            trainee1.ShowWorker();
            trainee1.ShowSalary();
            trainee1.Present();
            var fulltime1 = new FullTime("Someone Something",20);
            fulltime1.CalculateSalary();
            fulltime1.Present();
            fulltime1.ShowSalary();
            fulltime1.ShowWorker();
            fulltime1.ChangeContract(fulltime1);
            fulltime1.CalculateSalary();
            fulltime1.ShowWorker();
            fulltime1.ShowSalary();
            fulltime1.Present();
        }
    }
}
