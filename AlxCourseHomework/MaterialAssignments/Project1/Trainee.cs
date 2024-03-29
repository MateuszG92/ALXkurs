﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AlxCourseHomework.MaterialAssignments.Project1
{
    public class Trainee : Worker , IWorker
    {

        public Trainee(string name):base()
        {
            MonthlyRate = 1000;
            Name = name;
            Contract = EnumContractTypes.TRAINEE;
        }
        public override void ShowWorker()
        {
            Console.WriteLine($"Worker name: {Name}");
            Console.WriteLine($"Worek contract: {Contract}");;
            Console.WriteLine($"Salary: {Math.Round(Salary,2)}");
        }
        public override double CalculateSalary()
        {
            return Salary = MonthlyRate;
        }
    }
}
