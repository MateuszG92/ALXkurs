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
            var addingGun=new AddingGun();
            Console.WriteLine("Welcom in shooting range");
            Console.WriteLine("Guns list");
            foreach (var gunType in Enum.GetValues(typeof(EnumTypeOfGuns)))
            {
                Console.WriteLine(gunType);
            }
            Console.WriteLine("Want to create new shooting list? (Y/N)"); 
            var wantToAddNextGun = Console.ReadLine().ToUpper();
            while (wantToAddNextGun == "Y")
            {
                Console.Write("Enter chosen gun: ");
                EnumTypeOfGuns chosenGun = (EnumTypeOfGuns)Enum.Parse(typeof(EnumTypeOfGuns), Console.ReadLine().ToUpper());
                if (Enum.IsDefined(typeof(EnumTypeOfGuns), chosenGun))
                {
                    addingGun.AddShootingWithChosenGun(chosenGun);
                    Console.WriteLine("Write Y to add new shot or N to show shooting list ");
                    wantToAddNextGun = Console.ReadLine().ToUpper();
                }
                else
                {
                    Console.WriteLine("No such gun in stock. Try again.");
                }

                if (wantToAddNextGun == "N")
                {
                    addingGun.ShowList();
                    Console.Write("Print receipt? (Y/N)? ");
                    var wantReceipt = Console.ReadLine().ToUpper();
                    if (wantReceipt == "Y")
                    {
                        addingGun.PrintReceipt();
                    }
                    else
                    {
                        Console.Write("Sayonara.");
                    }
                }
            }
        }
    }
}
