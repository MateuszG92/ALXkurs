﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class Rifle : Gun
    {
        public Rifle() : base()
        {
            Type = EnumTypeOfGuns.RIFLE;
            FullAutoMode = false;
            OneShotCost = 10;
        }
    }
}
