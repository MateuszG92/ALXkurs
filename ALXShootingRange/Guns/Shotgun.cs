﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class Shotgun : Gun
    {
        public Shotgun() : base()
        {
            Type = EnumTypeOfGuns.SHOTGUN;
            FullAutoMode = true;
            OneShotCost = 8;
        }
    }
}
