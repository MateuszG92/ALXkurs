﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class Pistol : Gun
    {
        public Pistol() : base()
        {
            Type = EnumTypeOfGuns.PISTOL;
            FullAutoMode = false;
            OneShotCost = 2;
        }
    }
}
