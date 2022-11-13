using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using alxkurs.Assigments.M1;

namespace alxkurs.Assigments.M2.L1
{
    public class SeniorityServiceTest
    {
        public static void Run()
        {
            var employee1 = new Employee("Ziutek", 3000, 6);
            var employee2 = new Employee("Zbyszek", 8000, 12);
            var employee3 = new Employee("Zdzichu", 12000, 3);
            var seniorityService = new SeniorityService();
            seniorityService.ClassifySeniorityByExperience(employee1);
            seniorityService.ClassifySeniorityByExperience(employee2);
            seniorityService.ClassifySeniorityByExperience(employee3);

            Console.WriteLine("Clasification by Experience");
            Console.WriteLine("Junors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
            seniorityService.ClearLists();

            seniorityService.ClassifySeniorityBySalary(employee1);
            seniorityService.ClassifySeniorityBySalary(employee2);
            seniorityService.ClassifySeniorityBySalary(employee3);

            Console.WriteLine("Clasification by Salary");
            Console.WriteLine("Junors: ");
            PresentEmployees(seniorityService.JuniorEmployees);
            Console.WriteLine("Mids: ");
            PresentEmployees(seniorityService.MidEmployees);
            Console.WriteLine("Seniors: ");
            PresentEmployees(seniorityService.SeniorEmployees);
        }

        public static void PresentEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee: {employee.Name}");
            }
        }
    }
}
