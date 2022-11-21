using ALXShootingRange.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class Gun:IShooitingRange
    {
        public double OneShotCost;
        public int NumberOfShots;
        public EnumTypeOfGuns Type;

        public Gun(EnumTypeOfGuns type)
        {
            Type = type;
            OneShotCost = 1;
        }

        public double ShootingCost(int numberOfShots)
        {
            NumberOfShots=numberOfShots;
            return OneShotCost*numberOfShots;
        }
    }
}
