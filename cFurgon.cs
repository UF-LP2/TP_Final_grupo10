﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFINALFINAL
{
    internal class cFurgon : cVehiculo
    {


        public cFurgon(int nafta_, int meses, float precio) : base(meses, nafta_, precio)
        {
            this.elevador = false;
            peso = 7000;
            volumen = 10000;
        }
        ~cFurgon() { }
    }
}
