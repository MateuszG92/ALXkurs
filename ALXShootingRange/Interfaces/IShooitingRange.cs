using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Interfaces
{
    public interface IShooitingRange
    {
        double ShootingSACost(int numberOfShots);
        double ShootingFACost(int numberOfShots);
    }
}
