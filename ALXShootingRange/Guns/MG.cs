using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    internal class MG : Gun
    {
        public MG() : base()
        {
            Type = EnumTypeOfGuns.MG;
            FullAutoMode = true;
            OneShotCost = 6;
        }
    }
}
