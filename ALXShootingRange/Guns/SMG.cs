﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXShootingRange.Guns
{
    public class SMG : Gun
    {
        public SMG() : base(EnumTypeOfGuns.SMG)
        {
            Type = EnumTypeOfGuns.SMG;
        }
    }
}
