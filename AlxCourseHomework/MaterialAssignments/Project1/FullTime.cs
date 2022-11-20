using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class FullTime : Worker
    {
        public FullTime(string firstName, string lastName, int overtime) : base(firstName, lastName)
        {
            MonthlyRate = 5000;
            Overtime = overtime;
            FirstName = firstName;
            LastName = lastName;
            Contract = EnumContractTypes.FULLTIME;
        }
        public double CalculateSalary()
        {
            Salary = MonthlyRate+(Overtime/60);
            return Salary;
        }
    }
}
