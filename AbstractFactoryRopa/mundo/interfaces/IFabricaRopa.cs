﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryRopa.mundo.interfaces
{
    interface IFabricaRopa
    {
        ICamisa crearCamisa();
        IPantalon crearPantalon();        
        IZapatos crearZapatos();
    }
} 
