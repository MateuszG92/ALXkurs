using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alxkurs.Lessons.M2.L1
{
    public class L1Lists
    {
        public static void Run()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("milk");
            ShowList(shoppingList);
            shoppingList.Add("eggs");
            ShowList(shoppingList);
            shoppingList.Add("cheese");
            ShowList(shoppingList);
            shoppingList.Add("meat");
            ShowList(shoppingList);

            shoppingList.Remove("meat");
            ShowList(shoppingList);
            shoppingList.Remove("milk");
            ShowList(shoppingList);
        }

        public static void ShowList(List<string> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
