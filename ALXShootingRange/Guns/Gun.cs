using ALXShootingRange.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class Gun
    {
        public double OneShotCost;
        public EnumTypeOfGuns Type;
        public bool FullAutoMode;

        public Gun()
        {
            OneShotCost = 1;
        }

        public double ShootingSACost(int numberOfShots)
        {
            return OneShotCost*numberOfShots;
        }

        public double ShootingFACost(int numberOfShots)
        {
            return ShootingSACost(numberOfShots)*1.15;
        }

        public bool CheckingGunFeatures(string shootingTypeChoice, bool fullAutomode)
        {
            if (shootingTypeChoice == "S")
            {
            return false;
            }
            else if (shootingTypeChoice == "F")
            {
                if (fullAutomode == true)
                {
                return true;
                }
                else
                {   
                Console.WriteLine("Gun has no such feature adding as single action shot");
                return false;
                }    
            }
            else
            {
                return false;
            };   
        }
    }
}
