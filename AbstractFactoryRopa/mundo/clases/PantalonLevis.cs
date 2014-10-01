using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;

namespace AbstractFactoryRopa.mundo.clases
{
    class PantalonLevis: IPantalon
    {
        public string darNombre()
        {
            return"Pantalon Levis";
        }
    }
}
