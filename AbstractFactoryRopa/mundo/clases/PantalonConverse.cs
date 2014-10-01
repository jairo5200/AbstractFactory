using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryRopa.mundo.interfaces;

namespace AbstractFactoryRopa.mundo.clases
{
    class PantalonConverse: IPantalon
    {
        public string darNombre()
        {
            return "Pantalon Converse";
        }
    }
}
