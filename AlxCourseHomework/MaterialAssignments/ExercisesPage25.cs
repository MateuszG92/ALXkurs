using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlxCourseHomework.MaterialAssignments
{
    public class ExercisesPage25
    {
        public static void Run61()
        {
            foreach(var month in Enum.GetValues(typeof(Months)))
            {
                Console.WriteLine(month);
            }
        }
        public static void Run62()
        {
            List<string> months = new List<string>();
            foreach (var month in Enum.GetValues(typeof(Months)))
            {
                months.Add(month.ToString());
            }
            for(int i = 0; i < months.Count; i++)
            {
                Console.WriteLine(months[i]);
            }
        }
    }
}
