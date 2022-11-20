using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlxCourseHomework.MaterialAssignments.Project1.Interfaces;


namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class Trainee : Worker 
    {

        public Trainee(string firstName, string lastName):base(firstName, lastName)
        {
            MonthlyRate = 1000;
            FirstName = firstName;
            LastName = lastName;
        }
        public double CalculateSalary()
        {
            Salary = MonthlyRate;
            return Salary;
        }
    }
}
