using ALXShootingRange.Guns;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ALXShootingRange
{
    public class AddingGun
    {
        List<string> ListOfUsedGuns = new List<string>();
        List<int> ShotsPerGun = new List<int>();
        List<double> PricePerGun = new List<double>();
        Gun newGun;

        public void ChoosingGunType(EnumTypeOfGuns choosingGun)
        {
            if (choosingGun == EnumTypeOfGuns.SHOTGUN)
            {
                newGun = new Shotgun();
                AddGunToList(newGun);
            }
            else if (choosingGun == EnumTypeOfGuns.PISTOL)
            {
                newGun = new Pistol();
                AddGunToList(newGun);
            }
            else if (choosingGun == EnumTypeOfGuns.RIFLE)
            {
                newGun = new Rifle();
                AddGunToList(newGun);
            }
            else if (choosingGun == EnumTypeOfGuns.SMG)
            {
                newGun = new SMG();
                AddGunToList(newGun);
            }
            else if (choosingGun == EnumTypeOfGuns.MG)
            {
                newGun = new MG();
                AddGunToList(newGun);
            }
        }

        public void AddGunToList(Gun thisGun)
        {
            Console.WriteLine("You chose: " + thisGun.Type.ToString());
            Console.Write("Full auto or single action (F/S)? ");
            var ShootingTypeChoice = Console.ReadLine().ToUpper();
            Console.Write("Enter number of shots: ");
            var chosenNumberOfShots = Int32.Parse(Console.ReadLine());
            if (thisGun.CheckingGunFeatures(ShootingTypeChoice, thisGun.FullAutoMode) == true)
            {
                ListOfUsedGuns.Add(thisGun.Type.ToString() + " full auto");
                ShotsPerGun.Add(chosenNumberOfShots);
                PricePerGun.Add(Math.Round(thisGun.ShootingFACost(chosenNumberOfShots), 2));
            }
            else
            {
                ListOfUsedGuns.Add(thisGun.Type.ToString() + " single action");
                ShotsPerGun.Add(chosenNumberOfShots);
                PricePerGun.Add(Math.Round(thisGun.ShootingSACost(chosenNumberOfShots), 2));
            }
        }

        public void ShowList()
        {
            Console.WriteLine("List of shots");
            for (int i = 0; i < ListOfUsedGuns.Count; i++)
            {
                Console.WriteLine($"Gun: {ListOfUsedGuns[i]} number of Shots: {ShotsPerGun[i]} Price netto: {PricePerGun[i]}");
            }
            Console.WriteLine("Summary netto:       \t" + SummingCost().ToString());
            Console.WriteLine("TAX 23%:             \t" + Math.Round(CalculateTax(23), 2).ToString());
            Console.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() - CalculateTax(23)), 2).ToString());
        }

        public decimal SummingCost()
        {
            decimal sum = 0;
            foreach (decimal i in PricePerGun)
            {
                sum += i;
            }
            return sum;
        }

        public decimal CalculateTax(decimal taxCharge)
        {
            decimal Tax;
            Tax = SummingCost() * taxCharge / 100;
            return Tax;
        }
        public void PrintReceipt()
        {
            using (StreamWriter writetext = new StreamWriter("receipt.txt"))
            {
                writetext.WriteLine("List of shots");
                for (int i = 0; i < ListOfUsedGuns.Count; i++)
                {
                    writetext.WriteLine($"Gun: {ListOfUsedGuns[i]} number of Shots: {ShotsPerGun[i]} Price netto: {PricePerGun[i]}");
                }
                writetext.WriteLine("Summary netto:       \t" + SummingCost().ToString());
                writetext.WriteLine("TAX 23%:             \t" + Math.Round(CalculateTax(23), 2).ToString()); 
                writetext.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() - CalculateTax(23)), 2).ToString());
            }
        }
    }
}

