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

        public void AddShootingWithChosenGun(EnumTypeOfGuns choosingGun)
        {
            if (choosingGun == EnumTypeOfGuns.SHOTGUN)
            {
                Shotgun newShotgun = new Shotgun();
                Console.WriteLine("You chose: " + newShotgun.Type.ToString());
                Console.Write("Full auto or single action (F/S)? ");
                var ShootingTypeChoice = Console.ReadLine().ToUpper();
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShotsShotgun = Int32.Parse(Console.ReadLine());
                if (newShotgun.CheckingGunFeatures(ShootingTypeChoice, newShotgun.FullAutoMode) == true)
                {
                    ListOfUsedGuns.Add(newShotgun.Type.ToString()+" full auto");
                    ShotsPerGun.Add(chosenNumberOfShotsShotgun);
                    PricePerGun.Add(Math.Round(newShotgun.ShootingFACost(chosenNumberOfShotsShotgun), 2));

                }
                else
                {
                    ListOfUsedGuns.Add(newShotgun.Type.ToString() + " single action");
                    ShotsPerGun.Add(chosenNumberOfShotsShotgun);
                    PricePerGun.Add(Math.Round(newShotgun.ShootingSACost(chosenNumberOfShotsShotgun), 2));
                }
            }
            else if (choosingGun == EnumTypeOfGuns.PISTOL)
            {
                Pistol newPistol = new Pistol();
                Console.WriteLine("You chose: " + newPistol.Type.ToString());
                Console.Write("Full auto or single action (F/S)? ");
                var ShootingTypeChoice2 = Console.ReadLine().ToUpper();
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShotsPistol = Int32.Parse(Console.ReadLine());
                if (newPistol.CheckingGunFeatures(ShootingTypeChoice2, newPistol.FullAutoMode) == true)
                {
                    ListOfUsedGuns.Add(newPistol.Type.ToString()+" full auto");
                    ShotsPerGun.Add(chosenNumberOfShotsPistol);
                    PricePerGun.Add(Math.Round(newPistol.ShootingFACost(chosenNumberOfShotsPistol), 2));
                }
                else
                {
                    ListOfUsedGuns.Add(newPistol.Type.ToString() + " single action");
                    ShotsPerGun.Add(chosenNumberOfShotsPistol);
                    PricePerGun.Add(Math.Round(newPistol.ShootingSACost(chosenNumberOfShotsPistol), 2));
                }
            }
            else if (choosingGun == EnumTypeOfGuns.RIFLE)
            {
                Rifle newRifle = new Rifle();
                Console.Write("Full auto or single action (F/S)? ");
                var ShootingTypeChoice3 = Console.ReadLine().ToUpper();
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShotsRifle = Int32.Parse(Console.ReadLine());
                if (newRifle.CheckingGunFeatures(ShootingTypeChoice3, newRifle.FullAutoMode) == true)
                {
                    ListOfUsedGuns.Add(newRifle.Type.ToString()+" full auto");
                    ShotsPerGun.Add(chosenNumberOfShotsRifle);
                    PricePerGun.Add(Math.Round(newRifle.ShootingFACost(chosenNumberOfShotsRifle), 2));
                }
                else
                {
                    ListOfUsedGuns.Add(newRifle.Type.ToString()+" single action");
                    ShotsPerGun.Add(chosenNumberOfShotsRifle);
                    PricePerGun.Add(Math.Round(newRifle.ShootingSACost(chosenNumberOfShotsRifle), 2));
                }
            }
            else if (choosingGun == EnumTypeOfGuns.SMG)
            {
                SMG newSMG = new SMG();
                Console.Write("Full auto or single action (F/S)? ");
                var ShootingTypeChoice4 = Console.ReadLine().ToUpper();
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShotsSMG = Int32.Parse(Console.ReadLine());
                if (newSMG.CheckingGunFeatures(ShootingTypeChoice4, newSMG.FullAutoMode) == true)
                {
                    ListOfUsedGuns.Add(newSMG.Type.ToString()+" full auto");
                    ShotsPerGun.Add(chosenNumberOfShotsSMG);
                    PricePerGun.Add(Math.Round(newSMG.ShootingFACost(chosenNumberOfShotsSMG), 2));
                }
                else
                {
                    ListOfUsedGuns.Add(newSMG.Type.ToString() + " single action");
                    ShotsPerGun.Add(chosenNumberOfShotsSMG);
                    PricePerGun.Add(Math.Round(newSMG.ShootingSACost(chosenNumberOfShotsSMG), 2));
                }
            }
            else if (choosingGun == EnumTypeOfGuns.MG)
            {
                MG newMG = new MG();
                Console.Write("Full auto or single action (F/S)? ");
                var ShootingTypeChoice5 = Console.ReadLine().ToUpper();
                Console.Write("Enter number of shots: ");
                var chosenNumberOfShotsMG = Int32.Parse(Console.ReadLine());
                if (newMG.CheckingGunFeatures(ShootingTypeChoice5, newMG.FullAutoMode) == true)
                {
                   ListOfUsedGuns.Add(newMG.Type.ToString() + " full auto");
                   ShotsPerGun.Add(chosenNumberOfShotsMG);
                   PricePerGun.Add(Math.Round(newMG.ShootingFACost(chosenNumberOfShotsMG), 2));
                }
                else
                {
                    ListOfUsedGuns.Add(newMG.Type.ToString() + " single action");
                    ShotsPerGun.Add(chosenNumberOfShotsMG);
                    PricePerGun.Add(Math.Round(newMG.ShootingSACost(chosenNumberOfShotsMG), 2));
                }
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
            Console.WriteLine("TAX 23%:             \t" + Math.Round((SummingCost() * 0.23), 2).ToString());
            Console.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() * 1.23), 2).ToString());
        }

        public int SummingCost()
        {
            int sum = 0;
            foreach (int i in PricePerGun)
            {
                sum += i;
            }
            return sum;
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
                writetext.WriteLine("TAX 23%:             \t" + Math.Round((SummingCost() * 0.23), 2).ToString());
                writetext.WriteLine("To pay (VAT included)\t" + Math.Round((SummingCost() * 1.23), 2).ToString());
            }
        }
    }
}

