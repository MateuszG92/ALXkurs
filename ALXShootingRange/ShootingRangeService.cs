using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ALXShootingRange.Guns;
using ALXShootingRange.Interfaces;

namespace ALXShootingRange
{
    public class ShootingRangeService
    {
        public static void Run()
        {
            List<string> ListOfUsedGuns = new List<string>();
            List<int> ShotsPerGun = new List<int>();
            List<double> PricePerGun = new List<double>();
            Console.WriteLine("Welcom in shooting range");
            Console.WriteLine("Guns list");
            foreach (var gun in Enum.GetValues(typeof(EnumTypeOfGuns)))
            {
                Console.WriteLine(gun);
            }
            Console.WriteLine("Want to create new shooting list? (Y/N)"); 
            var wantToAddNextGun = Console.ReadLine().ToUpper();
            while (wantToAddNextGun == "Y")
            {
                Console.WriteLine("Enter chosen gun: ");
                EnumTypeOfGuns chosenGun = (EnumTypeOfGuns)Enum.Parse(typeof(EnumTypeOfGuns), Console.ReadLine().ToUpper());
                if (Enum.IsDefined(typeof(EnumTypeOfGuns), chosenGun))
                {
                    AddGun(chosenGun);
                    Console.WriteLine("Want to add next gun (Y/N)? ");
                    wantToAddNextGun = Console.ReadLine().ToUpper();
                }
                else
                {
                    Console.WriteLine("No such gun in stock. Try again.");
                }
            }
            if (wantToAddNextGun == "N")
            {
                ShowList();
                Console.Write("Print receipt? (Y/N)? ");
                var wantReceipt = Console.ReadLine().ToUpper();
                if (wantReceipt == "Y")
                {
                    PrintReceipt();
                }
                else
                {
                    Console.WriteLine("Ending program.");
                    return;
                }
            }

            void AddGun(EnumTypeOfGuns choosingGun)
            {
                Gun newGun = new Gun(choosingGun);
                Console.WriteLine("You chose: " + newGun.Type.ToString());
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShots = Int32.Parse(Console.ReadLine());
                ListOfUsedGuns.Add(newGun.Type.ToString());
                ShotsPerGun.Add(chosenNumberOfShots);
                PricePerGun.Add(newGun.ShootingCost(chosenNumberOfShots));
            }    

            void ShowList()
            {
                Console.WriteLine("List of shots");
                for (int i = 0; i < ListOfUsedGuns.Count; i++)
                {
                    Console.WriteLine($"Gun: {ListOfUsedGuns[i]} Number of Shots: {ShotsPerGun[i]} Price netto: {PricePerGun[i]}");
                }
                Console.WriteLine("Summary netto:       \t" + SummingCost().ToString());
                Console.WriteLine("TAX 23%:             \t" + Math.Round((SummingCost() * 0.23), 2).ToString());
                Console.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() * 1.23), 2).ToString());
            }

            int SummingCost()
            {
                int sum=0;
                foreach(int i in PricePerGun)
                {
                    sum += i;
                }
                return sum;
            }

            void PrintReceipt()
            {         
                using (StreamWriter writetext = new StreamWriter("receipt.txt"))
                {
                    writetext.WriteLine("List of shots");
                    for (int i = 0; i < ListOfUsedGuns.Count; i++)
                    {
                        writetext.WriteLine($"Gun: {ListOfUsedGuns[i]} Number of Shots: {ShotsPerGun[i]} Price netto: {PricePerGun[i]}");
                    }
                    writetext.WriteLine("Summary netto:       \t" + SummingCost().ToString());
                    writetext.WriteLine("TAX 23%:             \t" + Math.Round((SummingCost() * 0.23),2).ToString());
                    writetext.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() * 1.23), 2).ToString());
                }
            }
        }
    }
}
